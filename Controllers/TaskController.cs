using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using todoapi.Models;

namespace todoapi.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class TaskController : ControllerBase
  {
    static List<Task> tasks = new List<Task>{
      new Task(){
        Id = 1,
        Importance = 10,
        Name = "Fist Task",
        Description = "My description",
        DueDate = "2020-07-27",
        TimeStamp = "1595829066306",
        Completed = true,
      },
      new Task(){
        Id = 2,
        Importance = 156,
        Name = "Fist Task",
        Description = "My description",
        DueDate = "1223421534",
        TimeStamp = "343425234",
        Completed = false,
      },
      new Task(){
        Id = 3,
        Importance = 103,
        Name = "Fist Task",
        Description = "My description",
        DueDate = "1223421534",
        TimeStamp = "343425234",
        Completed = true,
      },
    };

    [HttpGet("GetAll")]
    public IActionResult Get()
    {
      return Ok(tasks);
    }

    IEnumerable<Task> completedQuery =
    from task in tasks
    where task.Completed == true
    select task;

    [HttpGet("GetCompleted")]
    public IActionResult GetCompleted()
    {
      return Ok(completedQuery);
    }

		IEnumerable<Task> activeQuery =
    from task in tasks
    where task.Completed == false
    select task;


    [HttpGet("GetActive")]
    public IActionResult GetActive()
    {
      return Ok(activeQuery);
    }

  }
}