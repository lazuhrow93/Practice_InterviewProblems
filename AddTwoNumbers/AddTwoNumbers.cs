/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        //since its reverse order, we can just grab the first num and add from there.
        ListNode answer_Node = new ListNode(0);
        ListNode temp_current = answer_Node;
    
        int carry = 0;
        int current_sum = 0;
        int answer_node_val = 0;
        int l1Val = 0;
        int l2Val = 0;
        
        
        while(l1 != null || l2 != null){ //if one of the nodes is null, its okay just add that node's value to 0;
            
            if(l1 != null) l1Val = l1.val;
            else l1Val = 0;
            
            if(l2 != null) l2Val = l2.val;
            else l2Val = 0;
            
            current_sum = l1Val + l2Val + carry;
            carry = 0;
            carry = current_sum/10; //gives you the value to carry to the next num. so 9 + 9 = 18. carry will be 1
            temp_current.next = new ListNode(current_sum % 10); //init the next node
            temp_current = temp_current.next;
            if(l1 != null) l1 = l1.next;
            if(l2 != null) l2 = l2.next;
            
        }
        
        //if there is a carry
        if(carry > 0){
            temp_current.next = new ListNode(carry);
            
        }
        
        return answer_Node.next;
        
    }
}
