using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITScheduleChecking.Models
{
    public partial class Entities
    {

        public List<Task> getAllTask()
        {
            List<Task> tt = (from t in Tasks orderby t.orderID ascending select t).ToList();
            return tt;
            
        }

        //return false if any error is occurred durinn database operation. True if success
        public bool saveTaskRecord(List<String> doneAt100, List<String> doneAt600, List<String> doneAt400)
        {
            List<Task> tt = (from t in Tasks orderby t.orderID ascending select t).ToList();
            for (int i = 0; i < tt.Count; i++)
            {
                if (doneAt100.ElementAt(i) != null)//if it has null value then that task is not editable for 1:00 am. So just skip it.
                    tt.ElementAt(i).doneAt100 = doneAt100.ElementAt(i);
                if (doneAt600.ElementAt(i) != null)
                    tt.ElementAt(i).doneAt600 = doneAt600.ElementAt(i);
                if (doneAt400.ElementAt(i) != null)
                    tt.ElementAt(i).doneAt400 = doneAt400.ElementAt(i);
            }
            try
            {
                this.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }




    }
}