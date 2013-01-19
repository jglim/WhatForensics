WhatForensics
=========

A C# WhatsApp acquisition and analysis tool

  - Fast automatic acquisition
  - View device data without running (and modifying) WhatsApp
  - View extended data such as contact Jabber IDs, unsent messages and more!

When used in combination with the iTunes backup acquisition method, files on the devices will not be modified!

Features
-----------

WhatForensics uses three modes for data acquisition and analysis

* Load database automatically by browsing to iTunes backup folder
* Load database automatically from jailbroken iOS devices through AFC2 (may be forensically unsafe, although all operations are set as read-only)
* Manually load the database from disk 

Once data is loaded and successfully parsed, you can..

* View extended group info, number of messages, last person who messaged within a group, and their associated push IDs
* Search through data using SQLite LIKE syntax (e.g. %cheat%, %w___forensics%)
* View data with a threaded format
* View WhatsApp blacklist set by user
* View contact names as stored on device
* View unsent messages that was composed in the textfield
* Export a neat HTML report!
 

Screenshots
--------------

Main window with iTunes backup acquisition

![Main window with iTunes backup acquisition](https://raw.github.com/jglim/WhatForensics/master/Screenshots/MainWithAcquisition.png)

Group members with blacklist

![Group members with blacklist](https://raw.github.com/jglim/WhatForensics/master/Screenshots/GroupMembersWithBlacklist.png)

Wildcard Search

![Wildcard Search](https://raw.github.com/jglim/WhatForensics/master/Screenshots/WildcardSearch.png)

Generated Report

![Generated Report](https://raw.github.com/jglim/WhatForensics/master/Screenshots/GeneratedReport.png)

Usage
--------------

1. Compile or use the prebuilt binaries
2. Ensure uni.html exists within same folder (reporting format - can be modified!)
3. Run (AFC2 requires iTunes to be installed)

Version
-

1.0.0.1

License
-

MIT


TODO
--------------
* Load data from sqlite via column names rather than indexes (compatibility)
* Add more filters for the search
* Sanitize search parameters
* Tidy up MessageView code (especially owner highlighting)
* Implement a better alternative to Manzana (to extract WA db via iTunes HouseArrest, for non-jailbroken iOS devices)
* Clean up date codes
* Use MiscHelper to pass connection string around instead of parameters
