public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        // // get first number and second number
        // BigInteger N1 = 0, N2 = 0;
        // ListNode ListNodePtr = l1;

        // for (int i = 0; ListNodePtr != null; i++, ListNodePtr = ListNodePtr.next)
        //     N1 = N1 + ListNodePtr.val * (BigInteger)Math.Pow(10, (double)i);

        // ListNodePtr = l2;

        // for (int i = 0; ListNodePtr != null; i++, ListNodePtr = ListNodePtr.next)
        //     N2 = N2 + ListNodePtr.val * (BigInteger)Math.Pow(10, (double)i);

        // BigInteger sum = N1 + N2;

        // //create new linked list
        // string sumstr = Convert.ToString(sum);
        // ListNode Result = new ListNode(Convert.ToInt32(sumstr[sumstr.Length - 1] - '0'));
        // ListNodePtr = Result;
        // for (int i = sumstr.Length - 2; i >= 0; i--, ListNodePtr = ListNodePtr.next)
        //     ListNodePtr.next = new ListNode(Convert.ToInt32(sumstr[i]) - '0');

        // return Result;


            //another approach

            ListNode? ListNodePtr1 = l1;
            ListNode? ListNodePtr2 = l2;
            ListNode ListNodePtr3 = new ListNode(0);

            ListNode Result = ListNodePtr3;
            
            int LastCarryResult = 0;
            bool mylock = false;
            bool nullflag1 = false, nullflag2 = false;
            int localRes = 0;

            while (nullflag1 != true || nullflag2 !=true )
            {

                int val1 = 0, val2 = 0;

                if (nullflag1)
                    val1 = 0;
                else
                    val1 = ListNodePtr1.val;

                if (nullflag2)
                    val2 = 0;
                else
                    val2 = ListNodePtr2.val;

                //calculate Result
                localRes = val1 + val2 + LastCarryResult;
                //see if there's carry
                LastCarryResult = localRes > 9 ? 1 : 0;


                //enter once
                if (!mylock)
                {
                    ListNodePtr3.val = (localRes % 10);
                    mylock = true;
                }
                else
                {
                    //assign result
                    ListNodePtr3.next = new ListNode((localRes % 10));
                    ListNodePtr3 = ListNodePtr3.next;
                }


                //test nullability
                if (ListNodePtr1.next != null)
                    ListNodePtr1 = ListNodePtr1.next;
                else
                    nullflag1 = true;

                if (ListNodePtr2.next != null)
                    ListNodePtr2 = ListNodePtr2.next;
                else
                    nullflag2 = true;

            }

            //at exit we should calculate last node data
            if(LastCarryResult == 1)
                ListNodePtr3.next = new ListNode(LastCarryResult);

            return Result;

    }
}