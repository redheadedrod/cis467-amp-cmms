﻿using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;
using Antlr.Runtime;
using CIS467_AMP.Models;
using CIS467_AMP.Models.Maintenance;
using CIS467_AMP.Models.StockRoom;
using CIS467_AMP.Models.Shared;
using CIS467_AMP.ViewModels.Maintenance;
using WebGrease.Css.Ast.Selectors;
using static System.String;

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
            var workers = _context.Workers.ToList();
            var inventory = _context.AssetInventories.ToList();
            var status = _context.MaintenanceStatuses.ToList();
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
            return View(CreateViewModel(null, null));
        }

        public ActionResult EditWorkOrder(int? id, string message)
        {
            return View("EditWorkOrder", CreateViewModel(id, message));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(WorkOrderViewModel dataModel)
        {
            
            if (!ModelState.IsValid)
            {
                var workers = _context.Workers.ToList();
                var inventory = _context.AssetInventories.ToList();
                var status = _context.MaintenanceStatuses.ToList();
                var issues = _context.MaintenanceIssues;
                var plan = _context.JobPlans;
                int priority = dataModel.MaintenanceWorkOrder.Priority;
                var viewModel = new WorkOrderViewModel()
                {
                    Workers = workers,
                    AssetInventories = inventory,
                    MaintenanceStatuses = status,
                    MaintenanceIssue = issues,
                    JobPlan = plan,
                    Priority = priority,
                    Edit = false

                };
                return View("NewWorkOrder", viewModel); 
            }
            
            dataModel.MaintenanceWorkOrder.CreatedDateTime = DateTime.Now;
            dataModel.MaintenanceWorkOrder.LastStatusDateTime = DateTime.Now;
            dataModel.MaintenanceWorkOrder.MaintenanceStatusId = 0;
            _context.MaintenanceWorkOrders.Add(dataModel.MaintenanceWorkOrder);
            _context.SaveChanges(); 
            return RedirectToAction("Index", "Maintenance");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
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
                workOrder.CreatorId = viewModel.MaintenanceWorkOrder.CreatorId; // Remove once logins work
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
            var workTimes = _context.MaintenanceWorkOrderWorkTime.Where(wo => wo.MaintenanceWorkOrderId == id).ToList();
            var viewModel = new WorkTimeViewModel()
            {
                MaintenanceWorkOrderWorkTimes = workTimes,
                Worker = workers,
                Id = id
            };
            return View("AddWorkTime",viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddTime(WorkTimeViewModel time)
        {
            if (!ModelState.IsValid)
            {
                var workers = _context.Workers.ToList();
                var workTimes =
                    _context.MaintenanceWorkOrderWorkTime.Where(wo => wo.MaintenanceWorkOrderId == time.Id).ToList();
                var viewModel = new WorkTimeViewModel()
                {
                    MaintenanceWorkOrderWorkTimes = workTimes,
                    Worker = workers,
                    Id = time.Id
                };
                return View("AddWorkTime", viewModel);
            }
            if (time.MaintenanceWorkOrderWorkTime.StartTime < SqlDateTime.MinValue.Value)
            {
                time.MaintenanceWorkOrderWorkTime.StartTime = SqlDateTime.MinValue.Value;
            }
            var workOrder = _context.MaintenanceWorkOrders.Single(w => w.Id == time.Id);
            time.MaintenanceWorkOrderWorkTime.MaintenanceWorkOrder = workOrder;
            _context.MaintenanceWorkOrderWorkTime.Add(time.MaintenanceWorkOrderWorkTime);
            _context.SaveChanges();
            //return RedirectToAction("EditWorkOrder/"+time.Id, "Maintenance");
            return WorkTime(time.Id);
        }

        public ActionResult EditTime(int Id)
        {
            var timeRecord = _context.MaintenanceWorkOrderWorkTime.Single(wt => wt.Id == Id);
            var workers = _context.Workers.ToList();
            var workTimes = _context.MaintenanceWorkOrderWorkTime.Where(wo => wo.MaintenanceWorkOrderId == timeRecord.MaintenanceWorkOrderId).ToList();
            var viewModel = new WorkTimeViewModel()
            {
                MaintenanceWorkOrderWorkTimes = workTimes,
                Worker = workers,
                Id = timeRecord.MaintenanceWorkOrderId,
                MaintenanceWorkOrderWorkTime = timeRecord

            };
            return View("EditWorkTime", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SaveEditedTime(WorkTimeViewModel time)
        {
            if (!ModelState.IsValid)
            {
                var timeRecord = _context.MaintenanceWorkOrderWorkTime.Single(wt => wt.Id == time.Id);
                var workers = _context.Workers.ToList();
                var workTimes = _context.MaintenanceWorkOrderWorkTime.Where(wo => wo.MaintenanceWorkOrderId == timeRecord.MaintenanceWorkOrderId).ToList();
                var viewModel = new WorkTimeViewModel()
                {
                    MaintenanceWorkOrderWorkTimes = workTimes,
                    Worker = workers,
                    Id = timeRecord.MaintenanceWorkOrderId,
                    MaintenanceWorkOrderWorkTime = timeRecord

                };
                return View("EditWorkTime", viewModel);
            }
            var workTime = _context.MaintenanceWorkOrderWorkTime.Single(wt => wt.Id == time.MaintenanceWorkOrderWorkTime.Id);
            workTime.HoursWorked = time.MaintenanceWorkOrderWorkTime.HoursWorked;
            _context.SaveChanges();
            //return RedirectToAction("EditWorkOrder/" + time.MaintenanceWorkOrderWorkTime.MaintenanceWorkOrderId, "Maintenance");
            return WorkTime(time.MaintenanceWorkOrderWorkTime.MaintenanceWorkOrderId);
        }

        private JobPlanViewModel CreateJobPlanModel(int? id)
        {

            return null;
        }

        public ActionResult JobPlan(int id)
        {
            var workOrder = _context.MaintenanceWorkOrders.Single(wo => wo.Id == id);
            if (workOrder == null)
            {
                return Index();
            }
            if (workOrder.JobPlanId == null)
            {
                return EditWorkOrder(id, "No Work Plan attached to work order!");
            }
            var jobPlan = _context.JobPlans.Single(w => w.Id == workOrder.JobPlanId);
            if (jobPlan == null)
            {
                return EditWorkOrder(id, "No such Work Plan found on system!");
            }
            var jobPlanDocument = _context.JobPlanDocuments.Single(d => d.JobPlanId == jobPlan.Id);
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
                string partsList = Join(";", parts.Select(x => x.Id.ToString()).ToArray());
                partsList += ";"+ Join<int>(";", partNums);
                viewModel.PartsIdList = partsList;
                viewModel.PartNotesList = Join(";", partNotes);
            }
            return View("JobPlan",viewModel);
        }

        public PartsRequestViewModel BuildPartsViewModel(JobPlanViewModel formData)
        {
            var manufacturerPart = _context.ManufacturerParts
                .Include(m => m.Manufacturer)
                .ToList();
            ManufacturerPart part = null;
            var manufacturers = _context.Manufacturers.ToList();
            List<StockRoomRequestLine> requestLines = null;
            if (formData != null && formData.PartsIdList != null )  
            {
                part = new ManufacturerPart();
                requestLines = new List<StockRoomRequestLine>();
                string[] tokens = formData.PartsIdList.Split(';');
                int[] partIds = Array.ConvertAll<string, int>(tokens, int.Parse);
                int partIdsLen = partIds.Length / 2;
                StockRoomRequestLine requestLine;
                for (int i = 0; i < partIdsLen; i++)
                {
                    part = manufacturerPart.Single(m => m.Id == partIds[i]);
                    if (part != null)
                    {
                        requestLine = new StockRoomRequestLine();
                        requestLine.ManufacturerPart = part;
                        requestLine.Number = partIds[i + partIdsLen];
                        requestLine.Description = "Test" + part.Name;
                        requestLine.Id = i;
                        requestLines.Add(requestLine);
                    }
                }
            }
            var viewModel = new PartsRequestViewModel()
            {
                RequestLines = requestLines,
                ManufacturerParts = manufacturerPart,
                Manufacturers = manufacturers,
                WorkOrderNumber = null,
                JobPlanNumber = null
            };
            if (formData == null || formData.JobPlanId == null || formData.WorkOrderNumber == null) return viewModel;
            viewModel.WorkOrderNumber = (int) formData.WorkOrderNumber;
            viewModel.Lines = formData.PartsIdList;
            viewModel.Notes = formData.PartNotesList;
            viewModel.JobPlanNumber = (int) formData.JobPlanId;
            return viewModel;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PartsRequest(JobPlanViewModel formData)
        {
            var viewModel = BuildPartsViewModel(formData); 
            return View(viewModel);
        }

        public ActionResult BlankPartsRequest()
        {
            var viewModel = BuildPartsViewModel(null);
            return View("PartsRequest",viewModel);
        }

        public ActionResult EditPartsRequest(int id)
        {
            var viewModel = BuildPartsViewModel(null);
            viewModel.PartRequestNumber = id;
            List<int> lines = new List<int>();
            List<int> nums = new List<int>();
            List<string> notes = new List<string>();
            viewModel.RequestLines = new List<StockRoomRequestLine>();
            var requestLines = _context.StockroomRequestLines.Where(rl => rl.StockRoomRequestId == id).ToList();
            foreach (StockRoomRequestLine requestLine in requestLines)
            {
                viewModel.RequestLines.Add(requestLine);  
            }
            return View("PartsRequest", viewModel);
        }


        private struct RequestLineStruct
        {
            public int? PartId { get; set; }
            public int Number { get; set; }
            public string Note { get; set; }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult MakeRequest(PartsRequestViewModel formData)
        {
            //get information from form here:
            string value;
            int keyNumber;
            string[] keySplit;
            bool refresh = false;
            List<RequestLineStruct> requestLines = new List<RequestLineStruct>();
            RequestLineStruct requestLine = new RequestLineStruct()
            {
                Number = 0, Note = "", PartId = 0
            };
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
                else if ((key.StartsWith("RequestLine.") && (value != "0")) 
                    || (key.StartsWith("Note.")&& (requestLine.Note == null))
                    || (key.StartsWith("Part.")&& (value != "0"))
                    || (key.StartsWith("PartId.")))
                {
                    keySplit = key.Split('.');
                    keyNumber = Int32.Parse(keySplit[1]);
                    if (keySplit[0] == "RequestLine") // Take advantage of always having the order of requestLine, Note and PartId in same order...
                    {
                        if (value != "0")
                        {
                            requestLine.Number = Int32.Parse(value);
                            requestLine.PartId = null;
                            requestLine.Note = null;
                        }
                        else
                        {
                            requestLine.Number = 0;
                            requestLine.PartId = 0;
                            requestLine.Note = "";
                        }
                    }
                    else if (keySplit[0] == "Note" && requestLine.Note == null)
                    {
                        requestLine.Note = value ?? "";
                    }
                    else if (keySplit[0] == "PartId" && requestLine.PartId == null )
                    { 
                        requestLine.PartId = Int32.Parse(value);
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
            List<StockRoomRequestLine> requestLineList = new List<StockRoomRequestLine>();
            StockRoomRequestLine requestLineLine;

            var manufacturerPart = _context.ManufacturerParts.ToList();
            object stockRoomRequest = null;

            if (formData != null && formData.PartRequestNumber != null)
            {
                stockRoomRequest = _context.StockRoomRequests.Single(r => r.Id == (int)formData.PartRequestNumber);
            }
            
                
            for (int i = 0; i < requestLines.Count; i++)
            {
                requestLine = requestLines[i];
                requestLineLine = new StockRoomRequestLine();
                requestLineLine.ManufacturerPart = manufacturerPart.Single(p => p.Id == requestLine.PartId);
                requestLineLine.ManufacturerPartId = requestLineLine.ManufacturerPart.Id; 
                requestLineLine.Description = requestLine.Note;
                requestLineLine.Number = requestLine.Number;
                requestLineLine.Id = i;
                if (stockRoomRequest != null)
                {
                    requestLineLine.StockRoomRequest = (StockRoomRequest) stockRoomRequest;
                    requestLineLine.StockRoomRequestId = requestLineLine.StockRoomRequest.Id;
                }

                requestLineList.Add(requestLineLine);
            }
            if (refresh)
            {
            

            JobPlanViewModel buildModel = new JobPlanViewModel()
            {
                WorkOrderNumber = formData.WorkOrderNumber,
                JobPlanId = formData.JobPlanNumber, 
            };
            var viewModel = BuildPartsViewModel(buildModel);
                viewModel.RequestLines = requestLineList;
                if (formData.PartRequestNumber != null)
                    viewModel.PartRequestNumber = formData.PartRequestNumber;
                return View("PartsRequest", viewModel);

            }
            
            else
            {
                if (formData != null && formData.PartRequestNumber != null) // save changed record
                {
                    int requestId = (int) formData.PartRequestNumber;
                    var stockRoomRequestLines = _context.StockroomRequestLines;
                    var requestRecords = stockRoomRequestLines.Where(r => r.StockRoomRequestId == requestId).ToList();
                    StockRoomRequestLine record;
                    foreach (var line in requestLineList) // Change or add first
                    {
                        record = requestRecords.SingleOrDefault(r => r.ManufacturerPartId == line.ManufacturerPartId);
                        if (record != null)
                        {
                            record.Description = line.Description;
                            record.Number = line.Number;
                        }
                        else
                        {
                            stockRoomRequestLines.Add(line);
                        }
                    }
                    _context.SaveChanges();
                    bool done = false;
                    while (!done)
                    {
                        requestRecords = stockRoomRequestLines.Where(r => r.StockRoomRequestId == requestId).ToList();
                        bool doDelete;
                        foreach (var line in requestRecords) // Delete ones no longer needed
                        {
                            doDelete = true;
                            done = true;
                            foreach (var request in requestLineList)
                            {
                                if (request.ManufacturerPartId == line.ManufacturerPartId)
                                {
                                    doDelete = false;
                                    break;
                                }
                            }
                            if (doDelete)
                            {
                                var itemToRemove = _context.StockroomRequestLines.SingleOrDefault(x => x.Id == line.Id);
                                if (itemToRemove != null)
                                {
                                    _context.StockroomRequestLines.Remove(itemToRemove);
                                    _context.SaveChanges();
                                }
                                System.Diagnostics.Debug.WriteLine("Delete Record");
                                done = false;
                                break;
                            }
                        }
                        
                    }

                }
                else // new record
                {
                    // create a request first and get the id for it.
                    int workOrderNumber;
                    MaintenanceWorkOrder workOrder = null;
                    Worker worker = null;
                    var workers = _context.Workers.ToList();
                    StockRoomRequest newStockRoomRequest = new StockRoomRequest()
                    {
                        StockRoomRequestStatus = _context.StockRoomRequestStatuses.Single(i => i.Id == 0),
                        Requested = DateTime.Now,
                        Required = DateTime.Now.AddDays(14),
                        Approval = false

                    };
                    newStockRoomRequest.StockRoomRequestStatusId = newStockRoomRequest.Id;
                    if (formData != null && formData.WorkOrderNumber != null)
                    {
                        workOrderNumber = (int) formData.WorkOrderNumber;
                        workOrder = _context.MaintenanceWorkOrders.Single(id => id.Id == workOrderNumber);
                        if (workOrder.LeadWorkerId != null)
                        {
                            worker = workers.Single(i => i.Id == workOrder.LeadWorker.Id);
                            newStockRoomRequest.Worker = worker;
                            newStockRoomRequest.WorkerId = worker.Id;
                        }

                        newStockRoomRequest.MaintenanceWorkOrder = workOrder;
                        newStockRoomRequest.MaintenanceWorkOrderId = workOrder.Id;

                    }
                    else
                    {
                        // Will be replaced when logins are possible
                        Random rand = new Random();
                        Worker rndWorker = workers.ElementAt(rand.Next(_context.Workers.Count()));
                        newStockRoomRequest.Worker = rndWorker;
                        newStockRoomRequest.WorkerId = newStockRoomRequest.Worker.Id;
                    }
                    _context.StockRoomRequests.Add(newStockRoomRequest);
                    _context.SaveChanges();
                    int requestId = newStockRoomRequest.Id; // Id of new request
                    StockRoomRequest tempStockRoomRequest = _context.StockRoomRequests.Single(i => i.Id == requestId);
                    foreach (var line in requestLineList)
                    {
                        line.StockRoomRequest = tempStockRoomRequest;
                        line.StockRoomRequestId = tempStockRoomRequest.Id;
                        _context.StockroomRequestLines.Add(line);
                    }
                    _context.SaveChanges();

                }
            }


            return RedirectToAction("Index", "Maintenance");
        }
    }


}
