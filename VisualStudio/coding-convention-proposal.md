# Proposal for C# Coding standards and naming conventions

The suggestions below can be adapted to the group of participants, depending on the knowledge of the individual.
The idea is that after module 3, the rules whose suggestions are below start to apply.

The proposals were adopted from [MS C# Coding Conventions](https://github.com/dotnet/runtime/blob/main/docs/coding-guidelines/coding-style.md){target="_blank"}

---

| Term name                 | Notation   | Plural | Prefix | Suffix | Allowed characters | Underscores |
|:--------------------------|:-----------|:-------|:-------|:-------|:-------------------|:------------|
| Namespace name            | PascalCase | Yes    | Yes    | No     | [A-z][0-9]		 | No          |
| Class name                | PascalCase | No     | No     | Yes    | [A-z][0-9]         | No          |
| Constructor name          | PascalCase | No     | No     | Yes    | [A-z][0-9]         | No          |
| Method name               | PascalCase | Yes    | No     | No     | [A-z][0-9]         | No          |
| Method arguments          | camelCase  | Yes    | No     | No     | [A-z][0-9]         | No          |
| Local variables           | camelCase  | Yes    | No     | No     | [A-z][0-9]         | No          |
| Constants name            | PascalCase | No     | No     | No     | [A-z][0-9]         | No          |
| Field name                | camelCase  | Yes    | No     | No     | [A-z][0-9]         | Yes         |
| Properties name           | PascalCase | Yes    | No     | No     | [A-z][0-9]         | No          |
| Delegate name             | PascalCase | No     | No     | Yes    | [A-z]              | No          |
| Enum type name            | PascalCase | Yes    | No     | No     | [A-z]              | No          |


---