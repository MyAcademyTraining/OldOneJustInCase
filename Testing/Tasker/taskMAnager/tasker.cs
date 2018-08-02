
using System;
using System.Collections.Generic;
using System.Linq;

namespace taskManager.Models
{
    public class Tasker
    {
        private Ilogger logger;
        private IIdProvider idProvider;

        public ICollection<Task> Tasks { get; set; }

        public Tasker(Ilogger logger, IIdProvider idProvider)
        {
            this.Tasks = new List<Task>();
            this.logger = logger;
            this.idProvider = idProvider;
        }

        public void save(Task task)
        {
            //if (task == null)
            //{
            //    throw new ArgumentNullException();
            //}

            task.Id = idProvider.Id;
            this.Tasks.Add(task);
            try
            {
                this.logger.Log(string.Format("Added task {0}", task.Id));
            }
            catch (ArgumentNullException)
            {
            }
        }

        public void Delete(int id)
        {
            var taskFound = this.Tasks
                                    .SingleOrDefault(task => task.Id == id);

            if (taskFound == null)
            {
                this.logger.Log($"Task with{id} is not found");
                return;
            }
            this.Tasks.Remove(taskFound);
            this.logger.Log($"Task with{id} has been removed");
        }

        public void AllTasks()
        {
            foreach (var task in this.Tasks)
            {
                this.logger.Log($"Task [{task.Id}]");
            }
        }

        //markDone(task);
        //showAll();

    }
}
