# Grupo-A-Admin-Bar

# Sistema de Gestión Integral para un Bar

**Proyecto académico de la asignatura Diseño de Aplicaciones y Servicios para Internet (DASI)**

## 1. Descripción del proyecto

El presente proyecto consiste en el diseño y desarrollo de un sistema web para la gestión integral de un bar, con el propósito de optimizar los procesos operativos, administrativos y financieros del establecimiento.

El sistema permitirá administrar el menú, los productos, el inventario, los pedidos, las mesas, los clientes, los trabajadores y las finanzas del negocio. Además, facilitará la comunicación entre el personal de atención al cliente, cocina y barra, mediante el registro y seguimiento de los pedidos.

La aplicación se desarrollará utilizando ASP.NET Core Web API como backend y Blazor WebAssembly como frontend, con una base de datos relacional para almacenar y gestionar la información del establecimiento. El proyecto seguirá la metodología ágil Scrum, mediante el desarrollo incremental y la entrega progresiva de funcionalidades.

## 2. Objetivo del sistema

Desarrollar una aplicación web que permita centralizar y optimizar la gestión de un bar, mejorando el control de los recursos, la atención al cliente y la administración de las operaciones.

### Objetivos específicos

- Gestionar el menú y el catálogo de productos, incluyendo comidas, bebidas, cócteles, mocktails y sus respectivas variantes.
- Administrar el inventario de productos e insumos para conocer sus existencias y ubicación.
- Registrar y realizar el seguimiento de pedidos, identificando los productos solicitados y la mesa correspondiente.
- Facilitar la comunicación entre meseros, personal de cocina y bartenders mediante tickets de preparación.
- Gestionar las mesas y las cuentas asociadas a los pedidos.
- Administrar los usuarios y sus permisos de acuerdo con el rol que desempeñan.
- Registrar las ventas, controlar los gastos y generar reportes financieros.
- Facilitar los procesos de facturación e integrar una pasarela de pago, cuya selección está pendiente de confirmación.

## 3. Problemas identificados

Actualmente, se busca resolver las siguientes necesidades operativas del establecimiento:

- **Gestión del inventario:** dificultad para conocer la cantidad disponible y la ubicación de los productos e insumos.
- **Gestión de pedidos:** necesidad de identificar con claridad qué se ha solicitado y a qué mesa debe entregarse.
- **Comunicación interna:** posibilidad de errores en la preparación de comidas y bebidas por falta de información clara sobre los pedidos.
- **Atención al cliente:** necesidad de reducir los tiempos de espera y mejorar la coordinación del servicio.
- **Facturación y pagos:** necesidad de organizar el registro de las ventas, la generación de facturas y el procesamiento de pagos.
- **Control financiero:** necesidad de centralizar la información relacionada con los ingresos y los gastos del establecimiento.

El sistema pretende abordar estas necesidades mediante la digitalización y centralización de la información.

## 4. Módulos principales del sistema

### 4.1. Gestión de clientes
Permitirá registrar y consultar la información de los clientes cuando sea necesario para los procesos del establecimiento.

### 4.2. Gestión del menú y productos
Permitirá crear, consultar, modificar y actualizar el menú. Se contemplarán las diferentes categorías de productos y las variantes disponibles, como las salsas que pueden seleccionarse para determinadas comidas.

### 4.3. Gestión de pedidos
Permitirá registrar los pedidos, asociarlos con las mesas correspondientes y consultar su estado. También se contempla la generación de tickets destinados al personal de cocina y al bartender, según los productos solicitados.

### 4.4. Gestión de mesas
Permitirá administrar las mesas del establecimiento y facilitar su identificación durante la toma y entrega de pedidos.

### 4.5. Gestión de trabajadores y roles
Permitirá administrar las cuentas de los trabajadores y asignar permisos según sus responsabilidades dentro del establecimiento.

### 4.6. Gestión de cocina y barra
Facilitará la recepción y consulta de los pedidos que deben preparar los chefs y bartenders, con el fin de mejorar la coordinación y reducir errores de preparación.

### 4.7. Gestión de inventario y suministros
Permitirá consultar las existencias y la ubicación de los productos e insumos, así como apoyar el control de su disponibilidad. El método específico de gestión del inventario se encuentra pendiente de definición.

### 4.8. Gestión financiera
Permitirá registrar las ventas y los gastos del negocio, y facilitar la consulta de información financiera. Se contempla la integración de una pasarela de pago y la generación de facturas, conforme a los requisitos que se definan.

### 4.9. Gestión de música
Se contempla este módulo como parte de los posibles componentes del sistema. Sus funcionalidades y alcance se definirán posteriormente.

## 5. Usuarios del sistema

El sistema estará dirigido a los siguientes tipos de usuarios:

- **Clientes:** usuarios que podrán acceder a las funcionalidades de consulta o solicitud de pedidos que se definan para ellos.
- **Meseros:** responsables de registrar y consultar pedidos, así como identificar las mesas a las que deben entregarse.
- **Chefs:** responsables de consultar los pedidos correspondientes a la preparación de alimentos.
- **Bartenders:** responsables de consultar los pedidos relacionados con la preparación de bebidas.
- **Cajeros:** responsables de gestionar los cobros y las operaciones de facturación que se habiliten.
- **Administradores:** responsables de gestionar la configuración general, los productos, el inventario, los usuarios y los procesos administrativos autorizados.

Los permisos específicos de cada rol se establecerán durante el análisis de requisitos.

## 6. Tecnologías utilizadas

- **Backend:** ASP.NET Core Web API.
- **Frontend:** Blazor WebAssembly.
- **Lenguaje de programación:** C#.
- **Base de datos:** SQL Server.
- **Acceso a datos:** Entity Framework Core, previsto para la interacción con la base de datos.
- **Entorno de desarrollo:** Visual Studio.
- **Pruebas de API:** Postman y Swagger.
- **Control de versiones:** Git y GitHub.
- **Gestión ágil del proyecto:** Scrum, mediante un tablero en Trello o Jira.

## 7. Equipo Scrum

| Integrante | Rol |
|---|---|
| Jose Naranjo | Product Owner |
| Steven Tintín | Scrum Master |
| Xavier Anatoa | Equipo de desarrollo |
| Steven Tintín | Equipo de desarrollo |
| Mariano Zambrano | Equipo de desarrollo |

Los nombres y las responsabilidades definitivas del equipo se actualizarán conforme a la distribución acordada.

## 8. Product Backlog

El Product Backlog contendrá las historias de usuario, los requisitos y las funcionalidades planificadas para el sistema.

Enlace al tablero del proyecto: **(https://epn-team-mzczu5.atlassian.net/jira/software/projects/SCRUM/boards/1/not-found?atlOrigin=eyJpIjoiZDM4YjFlM2NkMjdkNDk4OTlkMTg4ODY4MjNhNzVkYjEiLCJwIjoiaiJ9)**

## 9. Estructura del proyecto

La solución estará organizada en dos proyectos principales:

- `BarAPI`: backend encargado de exponer los servicios mediante una API REST.
- `BarCliente`: frontend desarrollado con Blazor WebAssembly, encargado de la interfaz de usuario y de consumir los servicios de la API.

La estructura interna se definirá durante la configuración e implementación del proyecto.

## 10. Cómo ejecutar el proyecto

Las instrucciones de instalación y ejecución se completarán una vez configurados los proyectos y verificados los requisitos del entorno de desarrollo.

## 11. Alcance y evolución

El sistema se desarrollará de forma incremental a lo largo de los sprints establecidos para la asignatura. Las funcionalidades se implementarán según las prioridades del Product Backlog y los requisitos validados con el responsable del establecimiento.

Las decisiones relacionadas con las pasarelas de pago, el método de control de inventario, la facturación y el módulo de música se definirán durante las siguientes etapas del análisis.

## 12. Notas adicionales

- El proyecto se desarrolla con fines académicos.
- La aplicación busca mejorar la coordinación operativa y administrativa del establecimiento.
- Las funcionalidades finales estarán sujetas a la validación de los requisitos.
- El código fuente y la documentación se mantendrán en el repositorio de GitHub.
