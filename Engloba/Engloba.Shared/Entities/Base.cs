using Flunt.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engloba.Shared.Entities
{
    public abstract class Base : Notifiable<Notification>
    {
        protected Base()
        {
            Id = Guid.NewGuid();
            InsertDate = DateTime.Now;
        }

        public Guid Id { get; set; }
        public DateTime InsertDate { get; set; }
    }
}
