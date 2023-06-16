using System;
using System.Data.SqlClient;

namespace final_project
{
    internal class sqlconnection
    {
        private string v;

        public sqlconnection(string v)
        {
            this.v = v;
        }

        internal void Open()
        {
            throw new NotImplementedException();
        }

        internal void Close()
        {
            throw new NotImplementedException();
        }

        public static implicit operator SqlConnection(sqlconnection v)
        {
            throw new NotImplementedException();
        }

        internal void open()
        {
            throw new NotImplementedException();
        }

        internal void close()
        {
            throw new NotImplementedException();
        }
    }
}