# Lit

This is the Visualization part of our submission for HackZurich 2022 that made it to the finals. Our application helps the Lieutenant do get a better understand of the current situation of a burning building, by presenting a 3D view of this building. We can create such a 3D view out of 2D floor plans, the code for this can be found at [https://github.com/thearkamitra/HackZurich2022_LIT](https://github.com/thearkamitra/HackZurich2022_LIT). We allow intuitive usage of the 3D model by allowing to make parts of the building transparent, so that the Lieutenant can focus on the important parts of the building. In Addition, realtime data by motion sensors and temperature sensors can be used to show where the fire is currently spreading, supported by a simple fire simulation, and in which rooms there are currently humans that have to be saved or that are the firefighters. Finally, a dotted line shows the shortest path for the firefighters to reach civilians that have to be saved.

## Usage

Download and unzip the released build on Windows. Start the Lit.exe file.

* Use the keys 'wasd' to move the camera and 'ui', 'jk' and 'nm' for rotation
* Use the Arrow keys Up and Down to toggle visibility of building parts
* Press 'b' to let the firefighters move to the civilians along the shortest path

## Installation

We used Unity version 2021.3.2f1 to build the application. Simply clone this repository and open it in Unity and you are ready to go!

## Credits

This project has been created by Lucie Huang, Arka Mitra and Philip Neugebauer. The following free assets from the Asset store have been used:
* https://assetstore.unity.com/packages/3d/environments/urban/city-package-107224
* https://assetstore.unity.com/packages/tools/fire-propagation-92187
* https://assetstore.unity.com/packages/vfx/particles/fire-explosions/procedural-fire-141496
* https://assetstore.unity.com/packages/tools/integration/oculus-integration-82022

We thank the whole team of the HackZurich 2022 for creating this wonderful event and supporting us throughout the entire weekend. We thank Siemens for posting this exciting challenge to go from From Paper to 4D Buildings!
