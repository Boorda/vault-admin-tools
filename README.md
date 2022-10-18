# Vault-admin-tools
Admin and Migration Tools for Autodesk® Vault

```diff
- Note: There is no support, maintenance or roadmap for these tools.
```

## What the tools are
The tools provided here are command line utilities that are useful when setting up an Autodesk® Vault, administering it or migrating data into a Vault.

| Utility Name | Purpose |
| ------- | ------- |
| ImportFolderStructure-2022 | Import a folder structure into Autodesk Vault and apply categories, lifecycles, permissions and properties |
| ImportPropertyList-2022 | Populate existing User Defined Properties with lists of values |
| ImportNamingSchemeList-2022 | Import a list of naming scheme strings into a Vault naming scheme including codes and optionally description|
| ImportObjectProperties-2022 | Import Properties of Items, Files or Custom Entities into Autodesk Vault. Includes possibility to set Category, Revision and Lifecycle |
| VaultUserAccounts-2022 | (WIP - NOT COMPLETE) Imports or Exports users and groups to or from Autodesk Vault |

## How to use
See ./doc/Vault Admin Tools.rtf

**Note that in order to run the tools you will need to copy the following files from the Vault SDK into the directory containing your executable**

* Autodesk.Connectivity.WebServices.WCF.dll
* clmloader.dll

## Versioning
The version numbers for the tool executables correspond to the major version number of Vault they will run against

* Vault 2017 - Version 22
* Vault 2018 - Version 23
* Vault 2019 - Version 24
* Vault 2020 - Version 25
* Vault 2021 - Version 26
* Vault 2022 - Version 27
* Vault 2023 - Version 28

## License
See [LICENSE.md](LICENSE.md)

## Contributions
Read our contribution guidelines here: [CONTRIBUTE.md](CONTRIBUTE.md)
