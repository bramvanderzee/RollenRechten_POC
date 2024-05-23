namespace RollenRechten_POC.Models
{
    public class RightsGroup(string Name, IList<Right> Rights)
    {
        public int ID { get; }
        public string Name { get; set; } = Name;
        public IList<Right> Rights = Rights;

        public bool Add(Right right)
        {
            if (Rights.Contains(right))
            {
                return false;
            }

            Rights.Add(right);
            return true;
        }

        public bool Remove(Right right)
        {
            return Rights.Remove(right);
        }
    }
}
