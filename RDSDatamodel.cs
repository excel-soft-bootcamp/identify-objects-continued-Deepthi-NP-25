using System;
using System.Collections.Generic;
using System.Text;

namespace Company
{
        class RDSDataModel
        {
            private string CounterpartyID;
            private string Name;


            public string GetCounterpartyID()
            {
                return this.CounterpartyID;
            }
            public string GetName()
            {
                return this.Name;
            }
            public void SetCounterpartyID(string counterpartyid)
            {
                this.CounterpartyID = counterpartyid;
            }
            public void SetName(string name)
            {
                this.Name = name;
            }
        }
    }

