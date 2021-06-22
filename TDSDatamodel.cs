using System;
using System.Collections.Generic;
using System.Text;

namespace Company
{
    class TDSDatamodel
    {
        private string Trade_ID;
        private string Date;
        private int Current_trade_value;
        private string Counterparty_ID;
        public string GetTrade_ID()
        {
            return this.Trade_ID;
        }
        public string GetDate()
        {
            return this.Date;
        }
        public int GetCurrent_trade_value()
        {
            return this.Current_trade_value;
        }
        public string GetCounterparty_ID()
        {
            return this.Counterparty_ID;
        }
        public void SetTrade_ID(string trade_id)
        {
            this.Trade_ID = trade_id;
        }
        public void SetDate(string date)
        {
            this.Date = date;
        }
        public void SetCurrent_trade_value(int current_trade_value)
        {
            this.Current_trade_value = current_trade_value;
        }
        public void SetCounterparty_ID(string counterparty_id)
        {
            this.Counterparty_ID = counterparty_id;
        }
    }
}

