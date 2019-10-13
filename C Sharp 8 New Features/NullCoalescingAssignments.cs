namespace C_Sharp_8_New_Features
{
    public class NullCoalescingAssignments
    {
        public string CheckNullUsingConditions(string value)
        {
            if (value == null)
            {
                value = "Batman";
            }
            return value;
        }

        public string CheckNullUsingNullCoalescingOperator(string value)
        {
            value = value ?? "Batman";
            return value;
        }

        public string CheckNullUsingNullCoalescingAssignmentOperator(string value)
        {
            value ??= "Batman";
            return value;
        }
    }
}
