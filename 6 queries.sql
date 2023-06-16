/* 3.a  */
select Branch_number from Branch except (select employyee.Branch_number from 
(employyee inner join customer on employyee.id=customer.id))

/*3.b  */
select Branch_number from Branch except (select Branch_number from employyee )

/* 3.c */
 SELECT id, COUNT(id) 
FROM loan  GROUP BY id having count(id) =  (select max(loan.mycount)from (select  id,count(id) as mycount from loan group by id)loan);


/* 3.d */
SELECT SSN, COUNT(SSN) 
FROM take_by  GROUP BY SSN having count(SSN) =  (select max(take_by.mycount)from (select  SSN,count(SSN) as mycount from take_by group by SSN)take_by);


/* 3.e */
select * from customer where SSN IN (select SSN from customer except select SSN from take_by);

/* 3.f */
SELECT FristName, LastName,Address, SSN, phone,count(id) as Emp_num FROM CUSTOMER GROUP BY id, SSN, FristName, LastName, phone, Address
