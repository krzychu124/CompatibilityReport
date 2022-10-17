# Compatibility Report v2

Compatibility Report mod for [Cities: Skylines](https://steamcommunity.com/app/255710/workshop/). This reports compatibility issues and missing dependencies for your subscribed mods.

### Current status
This mod will be available soon the [Steam Workshop](https://steamcommunity.com/sharedfiles/filedetails/?id=). This is the official successor to the [Compatibility Rebort by Finwickle](https://github.com/Finwickle/CompatibilityReport) and [Mod Compatibility Checker](https://github.com/CitiesSkylinesMods/AutoRepair) by aubergine.


### Implemented features
* Detection of subscribed and local mods.
* XML catalog with basic mod information and compatibility information.
* Review of subscribed mods with the catalog information.
* HTML and/or text report, sorted by mod name. Split into multiple categories, based on issue severity.
* Automatic and on-demand download of a new catalog over FTP. No need for a mod update for every new mod or compatibility change.
* Mod options for easy access to reports, catalog download, feedback via report-form or on discord, links to recommended mods and also broken mods.
* Support for mod groups, to allow different editions (e.g. stable and test) of mods as mod requirement.
* Basic translation frame work (more to come)
* Catalog Updater method (for mod maintainer only), based on web crawling the Steam Workshop and CSV import.
  * Automatically detects new mods and changes in mod information: name, required DLC/mods, source URL, ...
  * Easy catalog maintenance with simple CSV files for updated mod and compatibility information. This allows for catalog maintenance by multiple people in the future.
  * Automatic change notes and catalog versioning.
  * Dedicated UI for easier maintenance.
  * Gzipped catalog for lower bandwidth usage (partially implemented).
  * Manual upload of a new catalog, after a quality assurance check (only for the owner of Compatibility Report v2).


### Roadmap and future ideas
The roadmap towards version 2.1 and the future ideas will be listed here:


### Credits
This mod is based on [Compatibility Rebort](https://github.com/Finwickle/CompatibilityReport) by Finwickle and uses code from [Mod Compatibility Checker](https://github.com/CitiesSkylinesMods/AutoRepair) by aubergine. It also uses code snippets from:
* **Enhanced District Services** by chronofanz a.k.a. Tim ([GitHub](https://github.com/chronofanz/EnhancedDistrictServices))
* **Change Loading Image 2** by BloodyPenguin ([GitHub](https://github.com/bloodypenguin/ChangeLoadingImage)) 
* **Loading Screen Mod** by thale5: ([GitHub](https://github.com/thale5/LSM))

Special thanks to:
* **krzychu124** for doing the coding part that where needed to come to v2.
* **Finwickle** for his great work on the first version of this mod and all the hours he also spent in testing mods! It's a honour for me to continue your work!
* **Aubergine** for the awesome MCC mod.
* **John Rambo**, for his contribution to the code.
* BloodyPenguin, Tim and thale5 for publishing the source code of their mods, from which some code is used.
* AquilaSol and Avanya for their famous [Broken/Incompatible Mod list](https://pdxint.at/BrokenModCS), i've the honour to participate my knowledge into too. All information from that document is included in this mod.
* Everyone who provided feedback in a comment, by the Google form, on GitHub, on discord or supported me with a donation!

Also thanks to:
* All modders for their great and often game-changing mods, and the hard work they put into them. And for sharing their source code for re-use and education.
* All modders and mod users that share their feedback and report their issues in the comments for all mods on the Workshop.
* All above and many others for providing a friendly atmosphere on Discord.


### Disclaimer
Life happpen, errors happen - so if you see one, please feel free to contact me.
