namespace Extension
{
    public static class MyExtension
    {
        public static string LeaderName(this List<object> groupList)
        {
            var firstValue = groupList.FirstOrDefault();         
            var res = firstValue?.GetType()?.GetProperty("Name")?.GetValue(firstValue, null)?.ToString();
            int.TryParse(res, out int n);
            return (n != 0 || res == null) ? "Wrong Input!!!" : res!;
        }
    }
}