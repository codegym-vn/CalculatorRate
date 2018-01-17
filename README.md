# CalculatorRate
Xây dựng một ứng dụng cho phép tính tiền cho vay lãi.

**Mục tiêu**

Luyện tập sử dụng vòng lặp for.

**Mô tả**

Trong phần này, chúng ta sẽ xây dựng một ứng dụng cho phép tính tiền cho vay lãi.
Ứng dụng cho phép nhập vào 3 tham số: số lượng tiền cho vay, tỉ lệ lãi suất theo tháng, số tháng cho vay. Ứng dụng sẽ hiển thị tổng số tiền có được khi hết thời hạn cho vay.

**Hướng dẫn**

Đầu tiên chúng ta xác định yêu cầu bài toán:

 - Ứng dụng cho phép nhập vào 3 tham số lần lượt là
   - Số lượng tiền cho vay
   - Tỉ lệ lãi suất theo tháng
   - Só tháng cho vay
 - Tính toán tổng tiền có được sau khi hết thời hạn
 
Phân tích:
 - Để tính tổng tiền lãi sau 1 tháng ta dùng công thức: Số tiền hiện có * tỉ lệ lãi suất. Ví dụ nếu số tiền cho vay là 1.000.000 (1 triệu) và tỉ lệ lãi suất là 5% thì ta có công thức tính tiền lãi là 1.000.000 * 0.05
 - Tổng số tiền có sau 1 tháng là 1.000.000 + 1.000.000 * 0.05 (*)
 
Cách giải:
 - Đọc các dữ liệu đầu vào từ bàn phím (số tiền, tỉ lệ lãi suất, số tháng cho vay).
 - Sử dụng vòng lặp for để tính toán tổng số tiền hiện có sau 1 tháng.
 
Chi tiết:
Viết code đọc dữ liệu từ bàn phím
Kiểm tra dữ liệu hợp lệ, lưu ý số tháng (thời gian cho vay) là kiểu int, dữ liệu tiền là kiểu decimal
Nếu dữ liệu hợp lệ sử dụng vòng lặp for lặp qua số tháng cho vay, dùng công thức (*) đã phân tích ở trên để tính tổng số tiền.
