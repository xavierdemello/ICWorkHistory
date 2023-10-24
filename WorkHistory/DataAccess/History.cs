using WorkHistory.Models;

namespace WorkHistory.DataAccess
{
    public class History
    {

        public Result AddNewHistory(HistoryEntry input)
        {
            Result result = Result.Error;

            int? resultNumber = 0;
            using (var context = new HistoryDataContext())
            {
                var linqData = context.AddHistory(input.WorkItemId, input.Name, input.Description, input.Hours, ref resultNumber);

                result = resultNumber > 0 ? Result.Success : Result.Error;
            }

            return result;
        }
    }
}
