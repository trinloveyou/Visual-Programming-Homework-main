namespace Sapoldanai
//64020811
{

    class Homework
    {
        // 1. เขียนโปรปกรมตรวจสอบคุณสมบัติผู้สมัครงาน โดยรับข้อมูลเป็นอายุ ประสบการณ์การทำงาน และการศึกษา
        public void CheckQualification(int age, string education, int experience)
        {
            // ถ้ามีอายุ 22-35 ปี
            if (age >= 22 && age <= 35)
            {
                // และมีปริญญาตรีขึ้นไป
                if (education == "ปริญญาตรี" || education == "ปริญญาโท" || education == "ปริญญาเอก")
                {
                    Console.WriteLine("คุณมีคุณสมบัติในการสมัครงาน");

                }
                else
                {
                    Console.WriteLine("คุณไม่มีคุณสมบัติในการสมัครงาน");
                }
            } // ถ้ามีอายุมากกว่า 35 ปี และประสบการณ์การทำงานมากกว่า 5 ปี
            else if (age > 35 && experience >= 5)
            {
                Console.WriteLine("คุณมีคุณสมบัติในการสมัครงาน");
            }
            else
            {
                Console.WriteLine("คุณไม่มีคุณสมบัติในการสมัครงาน");
            }

        }


        // 2. สร้างโปรแกรมตรวจสอบความถูกต้องของรหัสผ่าน โดยรับรหัสผ่านเป็น String และตรวจสอบเงื่อนไข
        public void CheckPassword(string password)
        {
            char[] spacialChar = ['!', '@', '#', '$', '%', '^', '&', '*'];
            // รหัสผ่านมีความยาวมากกว่า 8 ตัวอักษร
            if (password.Length >= 8)
            {
                // ประกอบด้วยตัวอักษรภาษาอังกฤษตัวพิมพ์ใหญ่อย่างน้อย 1 ตัว
                if (password.Any(char.IsUpper))
                {
                    // ประกอบด้วยตัวอักษรภาษาอังกฤษตัวพิมพ์เล็กอย่างน้อย 1 ตัว
                    if (password.Any(char.IsLower))
                    {
                        // ประกอบด้วยตัวเลขอย่างน้อย 1 ตัว
                        if (password.Any(char.IsDigit))
                        {
                            // ประกอบด้วยอักขระพิเศษอย่างน้อย 1 ตัว
                            if (password.Any(spacialChar.Contains))
                            {
                                Console.WriteLine("รหัสผ่านถูกต้อง");
                            }
                            else
                            {
                                Console.WriteLine("รหัสผ่านไม่ถูกต้อง");
                            }

                        }
                        else
                        {
                            Console.WriteLine("รหัสผ่านไม่ถูกต้อง");
                        }
                    }
                    else
                    {
                        Console.WriteLine("รหัสผ่านไม่ถูกต้อง");
                    }
                }
                else
                {
                    Console.WriteLine("รหัสผ่านไม่ถูกต้อง");

                }
            }
            else
            {
                Console.WriteLine("รหัสผ่านไม่ถูกต้อง");
            }
        }

        // 3. เขียนโปรแกรมตรวจสอบว่าวันที่ที่รับเข้ามาเป็นวันหยุดหรือไม่
        public void CheckHoliday(string day, bool isHoliday, bool isSpecialHoliday)
        {
            // วันหยุดคือวันเสาร์หรืออาทิตย์ || วันหยุดนักขัตฤกษ์ || วันหยุดพิเศษบริษัท
            if (day == "เสาร์" || day == "อาทิตย์" || isHoliday == true || isSpecialHoliday == true)
            {
                Console.WriteLine("วันนี้เป็นวันหยุด");
            }
            else
            {
                Console.WriteLine("วันนี้ไม่ใช่วันหยุด");
            }
        }

        // 4. เขียนโปรแกรมคำนวณค่าจัดส่งสินค้าเป็นกิโลกรัม แล้วคำนวณค่าจัดส่ง
        public void CalculateShippingCost(double weight)
        {
            // ถ้าน้ำหนักสินค้า 0-1 กิโลกรัม ค่าจัดส่ง 50 บาท
            if (weight >= 0 && weight <= 1)
            {
                Console.WriteLine("ค่าจัดส่งสินค้า 50 บาท");
            }
            // ถ้าน้ำหนักสินค้า 1-5 กิโลกรัม ค่าจัดส่ง 100 บาท
            else if (weight > 1 && weight <= 5)
            {
                Console.WriteLine("ค่าจัดส่งสินค้า 100 บาท");
            }
            // ถ้าน้ำหนักสินค้า 5-10 กิโลกรัม ค่าจัดส่ง 200 บาท
            else if (weight > 5 && weight <= 10)
            {
                Console.WriteLine("ค่าจัดส่งสินค้า 200 บาท");
            }
            // ถ้าน้ำหนักสินค้ามากกว่า 10 กิโลกรัม ค่าจัดส่ง 250 บาท
            else if (weight > 10)
            {
                Console.WriteLine("ค่าจัดส่งสินค้า 250 บาท");
            }
            else
            {
                Console.WriteLine("น้ำหนักไม่ถูกต้อง");
            }
        }

        // 5. สร้างโปรแกรมตรวจสอบปีอธิกสุรทิน (Leap Year) โดยรับปี ค.ศ. แล้วแสดงผลลัพธ์ว่าเป็นปีอธิกสุรทินหรือไม่
        public void CheckLeapYear(int year)
        {
            // ถ้าปีนั้นหารด้วย 4 ลงตัว และหารด้วย 100 ไม่ลงตัว หรือ หารด้วย 400 ลงตัว
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                Console.WriteLine("ปี " + year + " เป็นปีอธิกสุรทิน");
            }
            else
            {
                Console.WriteLine("ปี " + year + " ไม่เป็นปีอธิกสุรทิน");
            }
        }

        // 6. เขียนโปรแกรมคำนวณภาษีเงินได้ โดยรายรับต่อปีแล้วคำนวณภาษีนตามอัตราก้าวหน้า
        public void CalculateTax(double income)
        {
            // ถ้ารายได้ต่อปีน้อยกว่า 150,000 บาท ไม่ต้องเสียภาษี
            if (income < 150000)
            {
                Console.WriteLine("ไม่ต้องเสียภาษี");
            }
            // ถ้ารายได้ต่อปี 150,001-300,000 บาท ภาษี 5%
            else if (income >= 150001 && income <= 300000)
            {
                Console.WriteLine("ภาษีที่ต้องเสีย " + (income * 0.05) + " บาท");
            }
            // ถ้ารายได้ต่อปี 300,001-500,000 บาท ภาษี 10%
            else if (income >= 300001 && income <= 500000)
            {
                Console.WriteLine("ภาษีที่ต้องเสีย " + (income * 0.1) + " บาท");
            }
            // ถ้ารายได้ต่อปี 500,001 ขึ้นไป ภาษี 15%
            else if (income > 500001)
            {
                Console.WriteLine("ภาษีที่ต้องเสีย " + (income * 0.15) + " บาท");
            }
        }

        // 7. สร้างโปรแกรมแปลงหน่วยอุณหภูมิ โดยรับค่าอุณหภูมิและหน่วย(C, F, K) แล้วแปลงเป็นหน่วยอื่นทั้งหมด
        public void ConvertTemperature(double temperature, string unit)
        {
            // หากหน่วยที่รับมาเป็น C
            if (unit == "C")
            {
                // แปลงเป็น F
                Console.WriteLine("อุณหภูมิ " + temperature + " องศาเซลเซียส เท่ากับ " + ((temperature * 9 / 5) + 32) + " องศาฟาเรนไฮต์");
                // แปลงเป็น K
                Console.WriteLine("อุณหภูมิ " + temperature + " องศาเซลเซียส เท่ากับ " + (temperature + 273.15) + " องศาเคลวิน");
            }
            // หากหน่วยที่รับมาเป็น F
            else if (unit == "F")
            {
                // แปลงเป็น C
                Console.WriteLine("อุณหภูมิ " + temperature + " องศาฟาเรนไฮต์ เท่ากับ " + ((temperature - 32) * 5 / 9) + " องศาเซลเซียส");
                // แปลงเป็น K
                Console.WriteLine("อุณหภูมิ " + temperature + " องศาฟาเรนไฮต์ เท่ากับ " + ((temperature - 32) * 5 / 9 + 273.15) + " องศาเคลวิน");
            }
            // หากหน่วยที่รับมาเป็น K
            else if (unit == "K")
            {
                // แปลงเป็น C
                Console.WriteLine("อุณหภูมิ " + temperature + " องศาเคลวิน เท่ากับ " + (temperature - 273.15) + " องศาเซลเซียส");
                // แปลงเป็น F
                Console.WriteLine("อุณหภูมิ " + temperature + " องศาเคลวิน เท่ากับ " + ((temperature - 273.15) * 9 / 5 + 32) + " องศาฟาเรนไฮต์");
            }
            else
            {
                Console.WriteLine("หน่วยไม่ถูกต้อง");
            }
        }

        // 8. เขียนโปรแกรมคำนวณค่าโดยสารรถไฟฟ้า BTS โดยรับจำนวนสถานีที่เดินทางแล้วคำนวณตามเงื่อนไข
        public void CalculateBTSFare(int station)
        {
            // 1-3 สถานี ค่าโดยสาร 16 บาท
            if (station >= 1 && station <= 3)
            {
                Console.WriteLine("ค่าโดยสาร " + station + " สถานี คือ 16 บาท");
            }
            // 4-8 สถานี ค่าโดยสาร 23 บาท
            else if (station >= 4 && station <= 8)
            {
                Console.WriteLine("ค่าโดยสาร " + station + " สถานี คือ 23 บาท");
            }
            // 9 สถานีขึ้นไป ค่าโดยสาร 31 บาท
            else if (station > 8)
            {
                Console.WriteLine("ค่าโดยสาร " + station + " สถานี คือ 31 บาท");
            }
            else
            {
                Console.WriteLine("จำนวนสถานีไม่ถูกต้อง");
            }
        }

        // 9. เขียนโปรแกรมหาจำนวนเฉพาะคู่แฝด (Twin Prime) ในช่วง 1 ถึง n โดยรับค่า n จากผู้ใช้ จำนวนเฉพาะคู่แฝดคือจำนวนเฉพาะที่ห่างกันด้วย 2 เช่น 3 และ 5 หรือ 11 และ 13 
        private bool IsPrime(int number)
        {
            if (number < 2) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        public void FindTwinPrime(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (IsPrime(i) && IsPrime(i + 2))
                {
                    Console.WriteLine(i + " " + (i + 2));
                }
            }
        }

        // 10. สร้างโปรแกรมวาดรูปเลข 8 ด้วยเครื่องหมายดอกจันทร์ (*) โดยรับความสูงของตัวเลข 8 จากผู้ใช้ (ต้องเป็นเลขคี่ที่มากกว่า 5) ถ้าผู้ใช้ป้อนข้อมูลไม่ถูกให้ขอข้อมูลใหม่จนกว่าจะถูกต้อง
        public void DrawNumber8(int height)
        {
            if (height % 2 == 0 || height <= 5)
            {
                Console.WriteLine("ความสูงไม่ถูกต้อง");
            }
            else
            {
                int middle = height / 2;

                for (int i = 0; i < height; i++)
                {
                    if (i == 0 || i == middle || i == height - 1)
                    {
                        Console.WriteLine(new string('*', height));
                    }
                    else
                    {
                        Console.WriteLine("*" + new string(' ', height - 2) + "*");
                    }
                }

            }
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Homework homework = new Homework();

            homework.CheckQualification(36, "ประถมศึกษา", 5);
            homework.CheckPassword("Trin@@555555");
            homework.CheckHoliday("จันทร์", false, false);
            homework.CalculateShippingCost(10);
            homework.CheckLeapYear(2024);
            homework.CalculateTax(550000);
            homework.ConvertTemperature(50, "K");
            homework.CalculateBTSFare(3);
            homework.FindTwinPrime(50);
            homework.DrawNumber8(9);
        }
    }
}