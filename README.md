# MT950 to CAMT.053 Converter

## Overview
The **MT950ToCamtConverter** is a .NET project that converts **SWIFT MT950 bank statement messages** into the **CAMT.053 XML format**, following the latest ISO 20022 standard.  
This project is designed for financial applications that need to integrate legacy SWIFT statements into modern ISO-compliant systems.

---

## Features
- Parse MT950 statements from text files.
- Map transactions and balances to CAMT.053 structures.
- Support for multiple accounts and currencies.
- Unit tests included in the `MT950ToCamtConverter.Tests` project.
- Generates CAMT.053 XML output files ready for downstream processing.

---

## Folder Structure
MT950ToCamtConverter/
├─ Input/ # Sample MT950 files to parse
├─ Output/ # Generated CAMT.053 XML files
├─ Mappers/ # Mapping logic from MT950 to CAMT.053
├─ Parsers/ # MT950 parsing logic
├─ Models/ # Data models for MT950 and CAMT.053
├─ Schemas/ # CAMT.053 schema references
├─ MT950ToCamtConverter.sln
└─ MT950ToCamtConverter.csproj


---

## Getting Started

### Prerequisites
- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- Windows, macOS, or Linux

### Build & Run
1. Clone the repository:
```bash
git clone https://github.com/CoderBrian357NYC/MT950ToCamtConverter.git
cd MT950ToCamtConverter

Restore dependencies and build:
dotnet restore
dotnet build

Run the converter:
dotnet run --project MT950ToCamtConverter


Run Tests
dotnet test ../MT950ToCamtConverter.Tests
