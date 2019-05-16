# CellComplete
Active and inactive cells after k days


Given a binary array of size n where n > 3. A true (or 1) value in the array means active and false (or 0) means inactive. 
Given a number k, the task is to find count of active and inactive cells after k days. 
After every day, status of i’th cell becomes active if left and right cells are not same 
and inactive if left and right cell are same (both 0 or both 1).
Since there are no cells before leftmost and after rightmost cells, the value cells before leftmost 
and after rightmost cells is always considered as 0 (or inactive).
