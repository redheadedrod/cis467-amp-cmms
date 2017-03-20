using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Antlr.Runtime;
using CIS467_AMP.Models;
using CIS467_AMP.Models.Maintenance;
using CIS467_AMP.Models.StockRoom;
using CIS467_AMP.Models.Shared;
using CIS467_AMP.ViewModels.Maintenance;

namespace CIS467_AMP.Controllers.Maintenance
{
    public class MaintenanceController : Controller
    {

        //Disposable object allowing for data querying.
        private ApplicationDbContext _context;

        public MaintenanceController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Maintenance
        public ActionResult Index()
        {
            var workOrder = _context.MaintenanceWorkOrders
                .Include(a => a.AssetInventory)
                .Include(w => w.Creator)
                .Include(s => s.MaintenanceStatus)
                .Include(l => l.LeadWorker)
            ;
            return View(workOrder);
        }

        private WorkOrderViewModel CreateViewModel(int? id, string message)
        {
            var workers = _context.Workers;
            var inventory = _context.AssetInventories;
            var status = _context.MaintenanceStatuses;
            var issues = _context.MaintenanceIssues;
            var plan = _context.JobPlans;
            int priority = 5;
            var viewModel = new WorkOrderViewModel()
            {
                Message = message,
                Workers = workers,
                AssetInventories = inventory,
                MaintenanceStatuses = status,
                MaintenanceIssue = issues,
                JobPlan = plan,
                Priority = priority,
                Edit = false
                
            };
            if (id != null)
            {
                var workOrder = _context.MaintenanceWorkOrders.FirstOrDefault(x => x.Id == id);
                if (workOrder != null)
                {
                    viewModel.MaintenanceWorkOrder = workOrder;
                    viewModel.Edit = true;
                    viewModel.Priority = workOrder.Priority;
                }
            }
            return (viewModel);
        }

        public ActionResult NewWorkOrder()
        {
            return View(CreateViewModel(null, ""));
        }

        public ActionResult EditWorkOrder(int? id, string message)
        {
            return View(CreateViewModel(id, message));
        }

        [HttpPost]
        public ActionResult Create(MaintenanceWorkOrder workOrder)
        {
            workOrder.CreatedDateTime = DateTime.Now;
            workOrder.LastStatusDateTime = DateTime.Now;
            workOrder.MaintenanceStatusId = 0;
            _context.MaintenanceWorkOrders.Add(workOrder);
            _context.SaveChanges(); 
            return RedirectToAction("Index", "Maintenance");
        }

        [HttpPost]
        public ActionResult Edit(WorkOrderViewModel viewModel)
        {
            if (Request.Form["time"] != null)
            {
                System.Diagnostics.Debug.WriteLine("Time");
                return WorkTime(viewModel.MaintenanceWorkOrder.Id);
            }

            else if (Request.Form["plan"] != null)
            { 
                System.Diagnostics.Debug.WriteLine("Plan");
                return JobPlan(viewModel.MaintenanceWorkOrder.Id);
            }
        else

        {
                System.Diagnostics.Debug.WriteLine("Save");
                var workOrder = _context.MaintenanceWorkOrders.Single(w => w.Id == viewModel.MaintenanceWorkOrder.Id);
                if (workOrder.MaintenanceStatusId != viewModel.MaintenanceWorkOrder.MaintenanceStatusId)
                {
                    workOrder.LastStatusDateTime = DateTime.Now;
                    workOrder.MaintenanceStatusId = viewModel.MaintenanceWorkOrder.MaintenanceStatusId;
                }
                else
                {
                    if (viewModel.MaintenanceWorkOrder.LastStatusDateTime < SqlDateTime.MinValue.Value)
                        viewModel.MaintenanceWorkOrder.LastStatusDateTime = SqlDateTime.MinValue.Value;
                }
                workOrder.AssetInventoryId = viewModel.MaintenanceWorkOrder.AssetInventoryId;
                if (viewModel.MaintenanceWorkOrder.CreatedDateTime < SqlDateTime.MinValue.Value)
                {
                    viewModel.MaintenanceWorkOrder.CreatedDateTime = SqlDateTime.MinValue.Value;
                }
                else
                {
                    workOrder.CreatedDateTime = viewModel.MaintenanceWorkOrder.CreatedDateTime;
                }
                workOrder.CreatorId = viewModel.MaintenanceWorkOrder.CreatorId;
                workOrder.JobPlanId = viewModel.MaintenanceWorkOrder.JobPlanId;
                workOrder.LeadWorkerId = viewModel.MaintenanceWorkOrder.LeadWorkerId;
                workOrder.MaintenanceIssueId = viewModel.MaintenanceWorkOrder.MaintenanceIssueId;
                workOrder.LongDesc = viewModel.MaintenanceWorkOrder.LongDesc;
                workOrder.ShortDesc = viewModel.MaintenanceWorkOrder.ShortDesc;
                workOrder.Priority = viewModel.MaintenanceWorkOrder.Priority;
                workOrder.SupervisorId = viewModel.MaintenanceWorkOrder.SupervisorId;
                _context.SaveChanges();
            }

            return RedirectToAction("Index", "Maintenance");
        }

        public ActionResult WorkTime(int id)
        {
            var workers = _context.Workers.ToList();
            var workOrder = _context.MaintenanceWorkOrders.Single(w => w.Id == id);
            var workTimes = _context.MaintenanceWorkOrderWorkTime.Where(wo => wo.MaintenanceWorkOrderId == id);
            var viewModel = new WorkTimeViewModel()
            {
               // MaintenanceWorkOrder = workOrder,
                MaintenanceWorkOrderWorkTimes = workTimes,
                Worker = workers,
                Id = id

            };
            return View("WorkTime",viewModel);
        }

        [HttpPost]
        public ActionResult AddTime(WorkTimeViewModel time)
        {
            if (time.MaintenanceWorkOrderWorkTime.StartTime < SqlDateTime.MinValue.Value)
                time.MaintenanceWorkOrderWorkTime.StartTime = SqlDateTime.MinValue.Value;
            var workOrder = _context.MaintenanceWorkOrders.Single(w => w.Id == time.Id);
            time.MaintenanceWorkOrderWorkTime.MaintenanceWorkOrder = workOrder;
            _context.MaintenanceWorkOrderWorkTime.Add(time.MaintenanceWorkOrderWorkTime);
            _context.SaveChanges();
            return WorkTime(time.MaintenanceWorkOrderWorkTime.MaintenanceWorkOrderId);
        }

        public ActionResult JobPlan(int id)
        {
            var workOrder = _context.MaintenanceWorkOrders.SingleOrDefault(wo => wo.Id == id);
            if (workOrder == null)
            {
                return Index();
            }
            if (workOrder.JobPlanId == null)
            {
                return EditWorkOrder(id, "No Work Plan found!");
            }
            var jobPlan = _context.JobPlans.SingleOrDefault(w => w.Id == workOrder.JobPlanId);
            if (jobPlan == null)
            {
                return EditWorkOrder(id, "No Work Plan found!");
            }
            var jobPlanDocument = _context.JobPlanDocuments.SingleOrDefault(d => d.JobPlanId == jobPlan.Id);
            if (jobPlanDocument == null)
            {
                return EditWorkOrder(id, "No Work Plan Document found!");
            }
            var manufacturerParts = _context.ManufacturerParts.ToList();
            var jobPlanParts = _context.JobPlanParts.Where(p => p.JobPlanId == jobPlan.Id);

            List<ManufacturerPart> parts = new List<ManufacturerPart>(); 
            List<int> partIds = new List<int>();
            List<int> partNums = new List<int>();
            List<string> partNotes = new List<string>();

            foreach (JobPlanPart item in jobPlanParts)
            {
                partIds.Add(item.ManufacturerPartId);
                partNums.Add(item.Number > 0 ? item.Number : 1);
                partNotes.Add("");
            }
            foreach (ManufacturerPart item in manufacturerParts)
            {
                if (partIds.Find(x => x.Equals(item.Id)) != 0)
                {
                    parts.Add(item);
                }
            }
            var viewModel = new JobPlanViewModel
            {
                JobPlan = jobPlan,
                JobPlanDocument = jobPlanDocument,
                JobPlanId = jobPlan.Id,
                WorkOrderNumber = id
            };
            if (parts.Any())
            {
                viewModel.ManufacturerParts = parts;
                string partsList = string.Join(";", parts.Select(x => x.Id.ToString()).ToArray());
                partsList += ";"+ string.Join<int>(";", partNums);
                viewModel.PartsIdList = partsList;
                viewModel.PartNotesList = string.Join(";", partNotes);
            }
            return View("JobPlan",viewModel);
        }


        [HttpPost]
        public ActionResult PartsRequest(JobPlanViewModel formData)
        {
            var manufacturerPart = _context.ManufacturerParts
                .Include(m => m.Manufacturer)
                .ToList();
            ManufacturerPart part = new ManufacturerPart();
            var manufacturers = _context.Manufacturers.ToList();
            List<StockRoomRequestLine> requestLines = new List<StockRoomRequestLine>();
            StockRoomRequestLine requestLine;
            string[] tokens = formData.PartsIdList.Split(';');
            int[] partIds = Array.ConvertAll<string, int>(tokens, int.Parse);
            int planId = formData.JobPlanId;
            int partIdsLen = partIds.Length / 2;
            for (int i = 0; i < partIdsLen; i++)
            {
                part = manufacturerPart.Single(m =>m.Id == partIds[i]);
                if (part != null)
                {
                    requestLine = new StockRoomRequestLine();
                    requestLine.ManufacturerPart = part;
                    requestLine.Number = partIds[i + partIdsLen];
                    requestLine.Description = "Test"+ part.Name;
                    requestLine.Id = i;
                    requestLines.Add(requestLine);
                }
            }

            var viewModel = new PartsRequestViewModel()
            {
                RequestLines = requestLines,
                ManufacturerParts = manufacturerPart,
                WorkOrderNumber = formData.WorkOrderNumber,
                Manufacturers = manufacturers,
                Lines = formData.PartsIdList,
                Notes = formData.PartNotesList,
                JobPlanNumber = formData.JobPlanId

            };
            return View(viewModel);
        }

        private struct RequestLineStruct
        {
            public int PartId { get; set; }
            public int Number { get; set; }
            public string Note { get; set; }
        }

        [HttpPost]
        public ActionResult MakeRequest(PartsRequestViewModel formData)
        {
            
            //get information from form here:
            string[] tokens = formData.Lines.Split(';');
            int[] partIds = Array.ConvertAll<string, int>(tokens, int.Parse);
            string value;
            int keyNumber;
            string[] keySplit;
            bool refresh = false;
            List<RequestLineStruct> requestLines = new List<RequestLineStruct>();
            RequestLineStruct requestLine = new RequestLineStruct();
            foreach (var key in Request.Form.AllKeys)
            {
                value = Request.Form.Get(key);
                if (key == "refresh")
                {
                    refresh = true;
                    System.Diagnostics.Debug.WriteLine("Refresh");
                }   
                else if (key == "place")
                {
                    System.Diagnostics.Debug.WriteLine("Place");
                }
                else if ((key.StartsWith("RequestLine.") && (value != "0")) || (key.StartsWith("Note.")&& (requestLine.Note == null))|| (key.StartsWith("Part.")&& (value != "0")))
                {
                    keySplit = key.Split('.');
                    keyNumber = Int32.Parse(keySplit[1]);
                    if (keySplit[0] == "RequestLine")
                    {
                        if (value != "0")
                        {
                            requestLine.Number = Int32.Parse(value);
                            requestLine.PartId = partIds[keyNumber];
                            requestLine.Note = null;
                        }
                    }
                    else if (keySplit[0] == "Note" && requestLine.Note == null)
                    {
                        requestLine.Note = value;
                        requestLines.Add(requestLine);
                    }
                    else if (keySplit[0] == "Part" && value!= "0")
                    {
                        requestLine.PartId = keyNumber;
                        requestLine.Number = Int32.Parse(value);
                        requestLine.Note = "";
                        requestLines.Add(requestLine);
                    }
                     
                        
                }
            }
            List<int> partIdList = new List<int>();
            List<int> numberList = new List<int>();
            List<string> noteList = new List<string>();

            foreach (var line in requestLines)
            {
                partIdList.Add(line.PartId);
                numberList.Add(line.Number);
                noteList.Add(line.Note);
            }
            string partString = string.Join<int>(";", partIdList) + ";" + string.Join<int>(";", numberList);
            string noteString = string.Join(";", noteList);

            if (refresh)
            {

                JobPlanViewModel viewModel = new JobPlanViewModel()
                {
                    WorkOrderNumber = formData.WorkOrderNumber,
                    PartsIdList = partString,
                    PartNotesList = noteString,
                    JobPlanId = formData.JobPlanNumber
                };
                //return RedirectToAction("PartsRequest", "Maintenance", viewModel);
            }
            else
            {
                //save code goes here

            }


            return RedirectToAction("Index", "Maintenance");
        }
    }


}
