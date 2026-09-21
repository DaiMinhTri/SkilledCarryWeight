> **Disclaimer:**
> Most of mods I work with are some old and outdated ones that their authors haven't updated so far to match 1.0. I am not a professional modder myself, but I am good with coding and gaming. If you experience any problems with the mods I published, you can find me in <a href="https://discord.com/channels/1522110224947871817/1522118606937133136">Hexium</a> discord server by typing DMT.

# DMT-SkilledCarryWeight

A Valheim mod that increases max carry weight based on skill level.
[Fork/update of Searica's SkilledCarryWeight](https://thunderstore.io/c/valheim/p/Searica/SkilledCarryWeight/), maintained for Valheim 1.0.x.
Independent fork — no Jotunn dependency, uses embedded ServerSync.

**GitHub:** <img height="18" src="https://github.githubassets.com/favicons/favicon-dark.svg"></img> [DaiMinhTri/SkilledCarryWeight](https://github.com/DaiMinhTri/SkilledCarryWeight)

## Features

### Skill-Based Carry Weight
Max carry weight increases based on skill level for each enabled skill. All vanilla skills are auto-detected, so new skills added in future updates will automatically be available for configuration.

Formula: `Increase = Coefficient * (Skill Level ^ Power)`

### Cart Mass Reduction
When `CarryWeightAffectsCart` is enabled, your increased max carry weight reduces the effective mass of carts you pull, making them easier to haul. A minimum carry weight threshold and maximum reduction cap prevent carts from becoming trivial.

Formula: `ModifiedMass = Max(Mass * (1 - MaxMassReduction), Mass * (MinCarryWeight/MaxCarryWeight) ^ Power)`

### Quick Cart
Press a hotkey (default `H`) to quickly attach to or detach from a nearby cart. Configurable attach distance and out-of-place attachment option.

### Server-Side Control
Configuration is synced from the server using embedded ServerSync. Clients cannot change synced settings unless the server allows it. Settings are also hot-reloadable via a file watcher or in-game configuration manager.

## Configuration

A configuration file is generated at `BepInEx/config/DMT.SkilledCarryWeight.cfg` after the first launch.

| Section | Setting | Default | Description |
|---------|---------|---------|-------------|
| Global | Verbosity | Low | Log level: Low, Medium, High (not synced) |
| Cart Mass | CarryWeightAffectsCart | On | Reduce cart mass based on carry weight |
| Cart Mass | Power | 1.0 | How much carry weight affects cart mass (0-3) |
| Cart Mass | MaxMassReduction | 0.70 | Maximum cart mass reduction (0-1) |
| Cart Mass | MinCarryWeight | 300 | Minimum carry weight before cart reduction applies (300-1000) |
| Quick Cart | QuickCartKey | H | Hotkey to attach/detach from cart (not synced) |
| Quick Cart | AttachDistance | 5 | Max distance to attach a cart (2-8) |
| Quick Cart | AttachOutOfPlace | On | Allow attaching cart when out of place |
| Skill | Enabled | Varies | Enable this skill to increase carry weight |
| Skill | Coefficient | 0.25 | Multiplier for skill level (0-10) |
| Skill | Power | 1.0 | Exponent for skill level (0-10) |

> **Note:** Skills enabled by default: Run, Jump, Swim, WoodCutting, Pickaxes, Ride, Sneak, Dodge, Farming. All other skills are disabled by default but can be enabled in the config.

## Compatibility

- **Standalone** — no Jotunn dependency; uses embedded ServerSync for config sync.
- Should be compatible with any mod that does not modify `Player.GetMaxCarryWeight` or `Vagon.GetHoverText`.
- Auto-detects all vanilla and modded skills from `Skills.s_allSkills`.

## Installation

1. Install [BepInEx](https://valheim.thunderstore.io/package/denikson/BepInExPack_Valheim/)
2. Download and extract `SkilledCarryWeight.dll` into your `BepInEx/plugins/` folder
3. Launch the game to generate the config file

## Credits

- Original mod by **Searica**
- ServerSync library by **Blitz**

## Buy Me a Coffee

If you enjoy this mod, consider buying me a coffee: [![Buy Me A Coffee](https://img.shields.io/badge/Buy%20Me%20A%20Coffee-daiminhtri-yellow)](https://buymeacoffee.com/daiminhtri)

## Changelog

### 1.5.0
- Updated for Deep North release
- Enabled Farming and Dodge skills by default
- Changed default cart keybind to avoid conflicting with new hotbar
- Replaced Jotunn dependency with embedded ServerSync library

### 1.4.1
- Added version check to enforce same version on client and server
- Updated to Jotunn 2.22.0 and restored pre Bog Witch config syncing behavior

### 1.4.0
- Updated for Bog Witch release

### 1.3.0
- Updated for Ashlands release

### 1.2.1
- Compiled against new version and updated Jotunn dependency

### 1.2.0
- Added quick attach/detach option for carts

### 1.1.2
- Bugfix for cart mass not being decreased correctly

### 1.1.1
- Fix README format

### 1.1.0
- Added options to reduce cart mass based on max carry weight
- Compiled against newest game version
- Minor performance optimizations
- Updated icon

### 1.0.0/1.0.1
- Initial release
