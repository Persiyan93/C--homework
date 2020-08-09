using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Robot:IIdentifiable
    {
        public Robot(string model,string id)
        {
            this.Model = model;
            this.Id = id;
        }
        public string Model { get; set; }
        private string id;
        public string Id { get => this.id; set =>this.id=value; }
        
    }
}
