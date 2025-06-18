# 🎓 Student-Course Enrollment System - Razor Pages (ITI Task)

A complete ASP.NET Core **Razor Pages** web application built as part of an ITI task. The system manages **Students**, **Courses**, and their **Enrollments**, using full **CRUD** operations, a clean layout, and client-side validation. It leverages **Entity Framework Core (Code First)** and follows best practices for maintainable and scalable web applications.

---

## 🚀 Features Implemented

- ✅ CRUD Operations for:
  - Students
  - Courses
  - Course Enrollments
- ✅ Responsive UI using **Bootstrap 5**
- ✅ Razor Pages architecture with page-based routing
- ✅ **Entity Framework Core - Code First** approach
- ✅ Full **Client-side Validation** (Unobtrusive)
- ✅ Shared Layout (`_Layout.cshtml`) for consistent UI
- ✅ Use of **Partial Views** for DRY form components
- ✅ Use of **Buddy Classes** for metadata separation and model annotations
- ✅ Navigation between modules (students, courses, enrollments)
- ✅ Well-structured and modular folder organization

---

## 🧱 Technologies Used

- ASP.NET Core Razor Pages (.NET 6 or .NET 7)
- Entity Framework Core (**Code First**)
- SQL Server / LocalDB
- Bootstrap 5
- C#
- Visual Studio 2022+

---

## 📂 Project Structure
firstRazor/
│
├── Pages/
│ ├── Students/
│ ├── Courses/
│ ├── Enrollments/
│ └── Shared/
│ └── _Layout.cshtml
│ └── _ValidationScriptsPartial.cshtml
│
├── Models/
│ ├── Student.cs
│ ├── Course.cs
│ ├── CourseEnrollment.cs
│ └── Metadata/
│ ├── StudentMetadata.cs
│ ├── CourseMetadata.cs
│
├── Data/
│ └── ApplicationDbContext.cs
│
├── wwwroot/
│ └── (Bootstrap, CSS, JS, etc.)
│
├── firstRazor.csproj
└── firstRazor.sln



