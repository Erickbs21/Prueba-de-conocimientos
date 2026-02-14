--1.Productos asignados al proyecto 1
use PRUEBATEC
SELECT pr.Nombre
FROM PROYECTO_PRODUCTO pp
JOIN PRODUCTO pr ON pp.IdProducto = pr.IdProducto
WHERE pp.IdProyecto = 1;

--2. Nombres de los mensajes asignados al producto 2
SELECT fm.Nombre
FROM MENSAJE m
JOIN FORMATO_MENSAJE fm ON m.IdFormato = fm.IdFormato
WHERE m.IdProducto = 2;

--3. Mensajes que NO están asignados al producto 3
SELECT fm.Nombre
FROM FORMATO_MENSAJE fm
WHERE fm.IdFormato NOT IN (
    SELECT m.IdFormato
    FROM MENSAJE m
    WHERE m.IdProducto = 3
);

--4. Productos que NO están asignados al proyecto 2
SELECT pr.Nombre
FROM PRODUCTO pr
WHERE pr.IdProducto NOT IN (
    SELECT pp.IdProducto
    FROM PROYECTO_PRODUCTO pp
    WHERE pp.IdProyecto = 2
);

--BONUS
SELECT 
    fm.Nombre AS Mensaje,
    p.Nombre AS Proyecto,
    CASE 
        WHEN COUNT(DISTINCT m.IdProducto) = 
             (SELECT COUNT(*) 
              FROM PROYECTO_PRODUCTO pp 
              WHERE pp.IdProyecto = m.IdProyecto)
        THEN 'TODOS'
        ELSE STRING_AGG(pr.Nombre, ', ')
    END AS Producto
FROM MENSAJE m
JOIN FORMATO_MENSAJE fm ON m.IdFormato = fm.IdFormato
JOIN PROYECTO p ON m.IdProyecto = p.IdProyecto
JOIN PRODUCTO pr ON m.IdProducto = pr.IdProducto
GROUP BY fm.Nombre, p.Nombre, m.IdProyecto;

