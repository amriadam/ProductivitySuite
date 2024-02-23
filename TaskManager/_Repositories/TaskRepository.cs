using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using TaskManager.Models;
using System.Globalization;

namespace TaskManager._Repositories
{
    public class TaskRepository : BaseRepository, ITaskRepository
    {

        public TaskRepository(string connectionString) {
            this.connectionString = connectionString;
        }

        public void Add(TaskModel task)
        {
            using (var connection = new SqlConnection(connectionString))
                using(var command = connection.CreateCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"Insert Task values (@title,@description,@dueDate,@status,@priority,@category)";
                command.Parameters.Add("@title", SqlDbType.NVarChar).Value = task.Title;
                command.Parameters.Add("@description", SqlDbType.NVarChar).Value = task.Description;
                command.Parameters.Add("@dueDate", SqlDbType.DateTime).Value = task.DueDate;
                command.Parameters.Add("@status", SqlDbType.NVarChar).Value = task.Status;
                command.Parameters.Add("@priority", SqlDbType.NVarChar).Value = task.Priority;
                command.Parameters.Add("@category", SqlDbType.NVarChar).Value = task.Category;
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int taskId)
        {
            var taskList = new List<Task>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"Delete  from Task where Task_Id = @id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = taskId;
                command.ExecuteNonQuery();
            }
        }

        public void Edit(TaskModel task)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"Update Task set Task_Title = @title, 
                                            Task_Description = @description,
                                            Task_DueDate = @dueDate, 
                                            Task_Status = @status,
                                            Task_Priority = @priority,
                                            Task_Category = @category
                                            where Task_Id = @id";

                command.Parameters.Add("@id", SqlDbType.Int).Value = task.Id;
                command.Parameters.Add("@title", SqlDbType.NVarChar).Value = task.Title;
                command.Parameters.Add("@description", SqlDbType.NVarChar).Value = task.Description;
                command.Parameters.Add("@dueDate", SqlDbType.DateTime).Value = task.DueDate;
                command.Parameters.Add("@status", SqlDbType.NVarChar).Value = task.DueDate;
                command.Parameters.Add("@priority", SqlDbType.NVarChar).Value = task.Priority;
                command.Parameters.Add("@category", SqlDbType.NVarChar).Value = task.Category;

                command.ExecuteNonQuery();
            }

        }

        public IEnumerable<TaskModel> GetAll()
        {
            var taskList = new List<TaskModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM TASK ";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        //Due Date
                        string dueDateString = reader["due_date"].ToString();
                        DateTime dueDate;

                        DateTime.TryParseExact(dueDateString, "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.None, out dueDate);

                        //Category
                        string categoryValue = reader["category"].ToString();
                        Category category;
                        Enum.TryParse(categoryValue, out category);

                        //priority
                        string priorityValue = reader["priority"].ToString();
                        Priority priority;
                        Enum.TryParse(priorityValue, out priority);

                        //status
                        string stringValue = reader["status"].ToString();
                        bool booleanValue;
                        bool.TryParse(stringValue, out booleanValue);
                        


                        var taskModel = new TaskModel
                        {
                            Id = (int)reader["id"],
                            Title = reader["title"].ToString(),
                            Description = reader["description"].ToString(),
                            DueDate = dueDate,
                            Category = category,
                            Priority = priority,
                            Status = booleanValue
                        };
                        taskList.Add(taskModel);
                    }
                }
            }
            taskList.ForEach(task => { Console.WriteLine("t : " + task.Title); });
            return taskList;
        }


        public IEnumerable<TaskModel> GetByValue(string value)
        {
            throw new NotImplementedException();
        }
    }
}
