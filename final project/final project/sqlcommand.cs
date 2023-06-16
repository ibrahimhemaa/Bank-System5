using System;

namespace final_project
{
    internal class sqlcommand
    {
        internal object parameters;
        private string v;
        private sqlconnection con;

        public sqlcommand(string v, sqlconnection con)
        {
            this.v = v;
            this.con = con;
        }

        public static sqlconnection Connection { get; internal set; }

        internal void ExecuteNoneQuary()
        {
            throw new NotImplementedException();
        }
    }
}