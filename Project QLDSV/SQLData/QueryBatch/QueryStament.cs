using System.Collections.Generic;

namespace SQLData.QueryBatch
{

    public class QueryStament : List<QueryColumn>
    {
        public Statement Statement { get; set; }
        public QueryStament(Statement statement)
        {
            Statement = statement;
        }
        public string ToNamesString()
        {
            string namesString = "";
            foreach (QueryColumn e in this)
            {
                namesString += $"{e.Name}, ";
            }
            return namesString.Substring(0, namesString.Length - 2);
        }
        public string ToValuesString()
        {
            string namesString = "";
            foreach (QueryColumn e in this)
            {
                namesString += $"{e.Value}, ";
            }
            return namesString.Substring(0, namesString.Length - 2);
        }
        public string ToPairsString()
        {
            string namesString = "";
            foreach (QueryColumn e in this)
            {
                namesString += $"{e.Name}={e.Value}, ";
            }
            return namesString.Substring(0, namesString.Length - 2);
        }
    }
}
