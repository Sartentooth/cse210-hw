using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Develop05
{
    public class ShowGoals : Goals
    {
        public void show(){
            base.ShowCurrentGoalsList();
        }
    }
}