/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        //Start i counter on L1 ,j counter on L2, K counter on new L3
        // if l1 element smaller add it, if bigger add the other
        // if elements remain add them
        ListNode list3 = new ListNode(0);
        ListNode Templist3 = list3;

        while(list1 != null && list2 != null)
        {
            if(list1.val < list2.val)
            {
                Templist3.next = new ListNode(list1.val);
                list1 = list1.next;
            }
            else if(list2.val <= list1.val)
            {
                Templist3.next = new ListNode(list2.val);
                list2 = list2.next;
            }
            Templist3 = Templist3.next;
        }

        while(list1 != null)
        {
            Templist3.next = new ListNode(list1.val);
            list1 = list1.next;
            Templist3 = Templist3.next;
        }

        while (list2 != null)
        {
            Templist3.next = new ListNode(list2.val);
            list2 = list2.next;
            Templist3 = Templist3.next;
        }

        list3 = list3.next;
        return list3;
    }
}