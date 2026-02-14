use PRUEBATEC
INSERT INTO PROYECTO (Nombre) VALUES ('Premia');
INSERT INTO PROYECTO (Nombre) VALUES ('Konmi');
INSERT INTO PROYECTO (Nombre) VALUES ('Gerencial');

INSERT INTO PRODUCTO (Nombre) VALUES ('Clasica');
INSERT INTO PRODUCTO (Nombre) VALUES ('Oro');
INSERT INTO PRODUCTO (Nombre) VALUES ('Platinum');

INSERT INTO PROYECTO_PRODUCTO VALUES (1,1);
INSERT INTO PROYECTO_PRODUCTO VALUES (1,2);
INSERT INTO PROYECTO_PRODUCTO VALUES (1,3);
INSERT INTO PROYECTO_PRODUCTO VALUES (2,1);
INSERT INTO PROYECTO_PRODUCTO VALUES (3,2);

INSERT INTO TIPO (Nombre) VALUES ('Texto');
INSERT INTO TIPO (Nombre) VALUES ('Email');
INSERT INTO TIPO (Nombre) VALUES ('Notificacion');

INSERT INTO TIPO_INFORMACION (Nombre) VALUES ('Bienvenido');
INSERT INTO TIPO_INFORMACION (Nombre) VALUES ('Excelente dia');
INSERT INTO TIPO_INFORMACION (Nombre) VALUES ('Saldo total');

INSERT INTO FORMATO_MENSAJE (IdTipo, IdTipoInfo, Nombre, Remitente, Asunto)
VALUES (2, 1, 'Formato Bienvenida Email', 'noreply@empresa.com', 'Bienvenido a Premia');

INSERT INTO FORMATO_MENSAJE (IdTipo, IdTipoInfo, Nombre, Remitente, Asunto)
VALUES (1, 3, 'Formato Saldo SMS', 'Sistema', 'Saldo Disponible');

INSERT INTO MENSAJE (IdFormato, IdProyecto, IdProducto)
VALUES (1,1,1);

INSERT INTO MENSAJE (IdFormato, IdProyecto, IdProducto)
VALUES (1,1,2);

INSERT INTO MENSAJE (IdFormato, IdProyecto, IdProducto)
VALUES (2,1,3);

INSERT INTO MENSAJE (IdFormato, IdProyecto, IdProducto)
VALUES (2,2,1);
