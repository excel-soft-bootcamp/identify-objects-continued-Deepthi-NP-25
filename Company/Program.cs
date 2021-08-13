using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Company
{
    class Program
    {
        static void Main(string[] args)
        {
            TDSDatamodel instance = new TDSDatamodel();
            RDSDataModel _instance = new RDSDataModel();

            instance.SetTrade_ID("Excel1");
            string tradeid = instance.GetTrade_ID();

            instance.SetDate("22-06-2021");
            string date = instance.GetDate();

            instance.SetCurrent_trade_value(50);
            int current_trade_value = instance.GetCurrent_trade_value();

            instance.SetCounterparty_ID("A01");
            string counterparty_id = instance.GetCounterparty_ID();

            _instance.SetCounterpartyID("B01");
            string counterpartyid = _instance.GetCounterpartyID();

            _instance.SetName("Tom");
            string name = _instance.GetName();


            System.Console.WriteLine(tradeid);
            System.Console.WriteLine(date);
            System.Console.WriteLine(current_trade_value);
            System.Console.WriteLine(counterparty_id);
            System.Console.WriteLine(counterpartyid);
            System.Console.WriteLine(name);

        }
    }
    }

