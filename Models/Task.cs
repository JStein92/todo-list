using System.Collections.Generic;

namespace ToDoList.Models
{
    public class Task
    {
        private string _description;
        private int _id;
        private static List<Task> _instances = new List<Task> {};

        public Task (string description)
        {
            _description = description;
            _instances.Add(this);
            _id = _instances.Count;
        }
        public string GetDescription()
        {
            return _description;
        }
        public void SetDescription(string newDescription)
        {
            _description = newDescription;
        }
        public static List<Task> GetAll()
        {
            return _instances;
        }
        public int GetId()
        {
            return _id;
        }
        public static Task Find(int searchId)
        {
            return _instances[searchId-1];
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }
    }
}
