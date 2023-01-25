namespace Console_LeetCode.Models
{
    public class ListNode
    {
        public int val;
        public ListNode next;

        //public ListNode(int[] vs)
        //{
        //  next = CreateListNode(vs);
        //}

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }

        public ListNode CreateListNode(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                new ListNode(i, new ListNode(array[i]));
            }

            return this.next;
        }
    }
}
