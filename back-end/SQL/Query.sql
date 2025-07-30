-- Muestra todos los usuarios son pacientes
SELECT id_rol as id_paciente,nombre, dni, Fecha_nacimiento, telefono 
 FROM Usuarios WHERE id_rol = 1; 

 -- Muestra todos los tecnicos
 SELECT id_rol as 'Técnico',nombre, dni, Fecha_nacimiento, telefono 
 FROM Usuarios WHERE id_rol = 2;

 -- Muestra todos los usuarios que tienen el rol de tecnico
SELECT u.id_rol, u.dni, u.nombre, u.Fecha_nacimiento, u.telefono, r.tipo
FROM Usuarios u
LEFT JOIN Roles r ON u.id_rol =r.Id_rol
WHERE r.tipo = 'Tecnico';

-- Muestra todos los usuarios que tienen el rol de tecnico o administrador
SELECT u.id_rol, u.dni, u.nombre, u.Fecha_nacimiento, u.telefono, r.tipo
FROM Usuarios u
LEFT JOIN Roles r ON u.id_rol =r.Id_rol
WHERE r.tipo IN ('Tecnico', 'Administrador');

