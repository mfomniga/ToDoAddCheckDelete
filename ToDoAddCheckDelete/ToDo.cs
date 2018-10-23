using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoAddCheckDelete
{
    public class ToDo
    {
        public ToDo(string name, bool erledigt)
        {
            this.Name = name;
            this.Checked = erledigt;
        }

        public string Name { get; set; }

        public bool Checked { get; set; }
    }
}
