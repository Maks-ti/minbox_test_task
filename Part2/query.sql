

select p."name" as product_name, c."name" as category_name  
from product as p
left join product_to_category as cp on p.id = cp.product_id
inner join category as c on cp.category_id = c.id

-- left join позволяет выбрать все продукты даже если нет категорий
