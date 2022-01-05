<?php
    include 'connect.php';
    $tendaili = $_POST['tendaily'];
    $sdt = $_POST['sodienthoai'];
    $diachi = $_POST['diachi'];
    $ngaydat = $_POST['ngaydathang'];
    $number = $_POST['number'];
    $tenmathang = $_POST['option'];
    $price = $_POST['price'];
    $optionthanhtoan = $_POST['optionthanhtoan'];
    
    $insertdaili = false;
    $inserthoadon = false;


    $queryInsertDaili = "INSERT INTO daily VALUES('$sdt','$tendaili','$diachi')";
    $queryInserthoadon = "INSERT INTO hoadon VALUES(null,'$sdt','$tendaili','$tenmathang','$number','$price','$optionthanhtoan','$ngaydat')";
    $queryCheckDaili = "SELECT sdt from daily WHERE sdt = '$sdt'";
    if(mysqli_num_rows(mysqli_query($conn,$queryCheckDaili)) == 0){
        if(mysqli_query($conn,$queryInsertDaili)){
            $insertdaili = true;
        }
        else{
            echo 'Error daili';
        }
        if(mysqli_query($conn,$queryInserthoadon)){
            $inserthoadon = true;
        }
        else{
            echo 'Error hoa don';
        }
    }
    else{
        if(mysqli_query($conn,$queryInserthoadon)){
            $inserthoadon = true;
            $insertdaili = true;
        }
        else{
            echo 'Error hoa don';
        }
    }
    if($insertdaili == true && $inserthoadon == true){
        echo 'Đặt hàng thành công';
        echo "<meta http-equiv='refresh' content='0.25;url=HomePage.html'>";
    }

?>