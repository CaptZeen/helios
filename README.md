### Helios Source Code Repository

This is the source code repository for the Helios Virtual Cockpit System for DCS World.  This repository is for core and module developers use.  If you are looking for end user downloads and documentation please visit http://www.gadrocsworkshop.com.

Helios is composed to two programs, the first **Profile Editor** allows the creation of virtual cockpits.  Visual components in the profile can then be bound to an interface which allows communication between DCS and the virtual cockpit.  Input bindings take DCS TRIGGERS and links them to ACTIONS on the visual components.  Output bindings take TRIGGERs in the virtual cockpit, and links them to ACTIONs on the interface into DCS.  The interface that gets bound to the visual components is usually aircraft specific.

The Helios **Control Center** program executes the profile that was created by the **Profile Editor** and displays the virtual cockpit, usually on a touch screen, for the virtual pilot to interact with.

When the aircraft specific interface is deployed from the **Profile Editor**, it creates an **exports.lua** script file in the %userprofile%\saved games\DCS\Scripts\ directory, and this is the code that is invoked by DCS at aircraft start-up, and communicates with the **Control Center** over a UDP link.

### Recent Change History

* March 2019 - Autobinding and Hornet IFEI & UFC demonstration [YouTube](https://www.youtube.com/watch?v=lEhG-TtENWc)
* October 2018 - Helios 1.4.2018.1008 Beta released including interfaces for Hornet and Harrier
* September 2018 - Helios 1.4.2018.0924 Beta released including interfaces for Hornet and Harrier
* May 2018 - AV-8B Interface - A video of the new AV-8B interface in action can be viewed on YouTube here [YouTube](https://www.youtube.com/watch?v=4kQG0dJMROg)
