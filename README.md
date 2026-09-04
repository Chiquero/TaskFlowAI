# 🚀 TaskFlow AI

> **Sistema Inteligente de Gestión de Tareas respaldado por .NET 8, Clean Architecture y Agentes de IA (MCP Protocol).**

[![.NET 8](https://img.shields.io/badge/.NET-8.0-512BD4?style=for-the-badge&logo=dotnet)](https://dotnet.microsoft.com/)
[![C# 12](https://img.shields.io/badge/C%23-12.0-239120?style=for-the-badge&logo=csharp)](https://learn.microsoft.com/en-us/dotnet/csharp/)
[![Clean Architecture](https://img.shields.io/badge/Architecture-Clean-blue?style=for-the-badge)](https://blog.cleancoder.com/uncle-bob/2012/08/13/the-clean-architecture.html)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg?style=for-the-badge)](LICENSE)

---

## 📌 ¿Qué es TaskFlow AI?

**TaskFlow AI** es una solución Backend desarrollada como proyecto de modernización tecnológica e innovación aplicada. Nace con el objetivo de servir como un **Showcase técnico** que demuestra la aplicación de patrones de diseño modernos, arquitectura limpia, integración continua y el uso de **Agentes de Inteligencia Artificial de última generación** en el ecosistema .NET.

El sistema permite gestionar flujos de trabajo y tareas mediante una API RESTful de alto rendimiento, enriquecida con capacidades de **clasificación automática de prioridades y análisis predictivo** mediante la integración de un **Servidor MCP (Model Context Protocol)** y el SDK de Microsoft para IA.

---

## 🏗️ Arquitectura y Principios de Diseño

El proyecto está estructurado siguiendo los principios de **Clean Architecture** (Arquitectura Limpia) y los principios **SOLID**, garantizando un alto desacoplamiento, mantenibilidad y facilidad para realizar pruebas unitarias.

```text
┌───────────────────────────────────────────────────────────┐
│                    TaskFlowAI.API                         │  ◄── Presentation Layer (Minimal APIs)
└─────────────────────────────┬─────────────────────────────┘
                              │
┌─────────────────────────────▼─────────────────────────────┐
│                TaskFlowAI.Application                     │  ◄── Use Cases, DTOs, FluentValidation
└─────────────────────────────┬─────────────────────────────┘
                              │
┌─────────────────────────────▼─────────────────────────────┐
│                  TaskFlowAI.Domain                        │  ◄── Core Entities, Value Objects, Interfaces
└─────────────────────────────▲─────────────────────────────┘
                              │
┌─────────────────────────────┴─────────────────────────────┐
│               TaskFlowAI.Infrastructure                   │  ◄── EF Core, Persistence, MCP & AI Agents
└───────────────────────────────────────────────────────────┘  
```
---

## 🛠️ Stack Tecnológico

* **Lenguaje & Runtimes:** .NET 8 & C# 12 *(Primary Constructors, Records, Pattern Matching)*
* **API:** ASP.NET Core con Minimal APIs y Swagger/OpenAPI
* **Persistencia:** Entity Framework Core (EF Core) + SQLite / SQL Server
* **Calidad & Testing:** xUnit, Moq, FluentAssertions
* **Integración de IA:** Microsoft Agent Framework & Model Context Protocol (MCP) para exposición de herramientas *(Tool Calling)* a LLMs
* **CI/CD:** GitHub Actions para ejecución automática de Tests y Build en cada `push`

---

## 🤖 Capacidades de IA (MCP Server)

A diferencia de las integraciones tradicionales con IA basadas en prompts simples, **TaskFlow AI** implementa un **Servidor MCP nativo en C#**. Esto permite que agentes autónomos de IA (como Claude Desktop, VS Code Copilot o agentes personalizados) interactúen de forma directa y segura con el dominio del sistema mediante la ejecución de herramientas *(Tool Calling)*.

### 💡 Casos de Uso de IA

* **Clasificación automática:** Determinación de la prioridad de una tarea en función del contexto.
* **Descomposición inteligente:** División de objetivos complejos en subtareas ejecutables.
* **Consultas contextuales:** Seguimiento del estado de las tareas mediante lenguaje natural.

---

## 🚀 Cómo Ejecutar el Proyecto Localmente

### Requisitos Previos
* **.NET 8 SDK** instalado.
* **Git** configurado.

### Pasos de Instalación

1. **Clonar el repositorio:**
   ```bash
   git clone [https://github.com/tu-usuario/TaskFlowAI.git](https://github.com/tu-usuario/TaskFlowAI.git)
   cd TaskFlowAI

2. **Restaurar dependencias:**
   ```bash
   dotnet restore

3. **Ejecutar las Pruebas Unitarias:**
   ```bash
   dotnet test

4. **Iniciar la API:**
   ```bash
   dotnet run --project TaskFlowAI.API

---

## 📊 Estado del Proyecto (Roadmap)

- [x] **Semana 1:** Inicialización de Solución, Git Flow y C# 12 Fundamentals.
- [ ] **Semana 2:** Modelado de Dominio y Capas de Clean Architecture.
- [ ] **Semana 3:** Implementación de Minimal APIs, Middlewares y Validaciones.
- [ ] **Semana 4:** Persistencia con Entity Framework Core y Migraciones.
- [ ] **Semana 5:** Suite de Tests Unitarios y Pipeline CI/CD en GitHub Actions.
- [ ] **Semana 6:** Integración de Servidor MCP y Agentes Autónomos con Microsoft Agent Framework.

## 📝 Licencia

Este proyecto se distribuye bajo la licencia MIT. Consulta el archivo `LICENSE` para obtener más información.