# Formal Elements – *City Between Realms*

## High Concept
A compact 2D city that **slides into a different dimension every night**. Each realm imposes unique rules (physics, time, economy, tech vs. magic). The player solves problems by understanding and exploiting these differences to reveal the source of the shifts.

## Target Audience
Players who enjoy narrative mysteries and systemic puzzles (13+). Fans of “The Medium”, “Titanfall 2 – Effect & Cause”, “A Link to the Past” (Light/Dark World), and story-driven indies.

## Platform
PC (Windows). Optional Web demo.

## Player Role & Objective
- **Role:** Investigator/scholar quietly tracking the phenomenon.  
- **Objective:** Decode the city’s pattern of shifts, help locals across realms, and reach the hidden mechanism that governs the cycle.

## Core Loop
1) **Survey the city** (talk, read signs, observe realm-specific rules) →  
2) **Plan** a cross-realm action (what to move, where, and when) →  
3) **Wait/trigger the nightly shift** →  
4) **Exploit new laws** to access blocked areas or transform objects →  
5) **Unlock new leads** → repeat until the core mystery is solved.

## Realms (MVP example set)
- **FUTURE** – surveillance drones, credits economy, fast time flow; electric locks; data terminals.  
- **FANTASY** – arcane wards, alchemy reagents, gold economy; living statues; slow time flow.  
- **POST-APOC** (optional third) – scavenging focus; collapsed routes; barter economy.

## Mechanics
- **Realm Shift Cycle:** Automatic at night (or at designated shrines later). City layout persists; props & rules swap per realm.  
- **Rule Board (UI):** displays active realm rules: time rate, economy, energy/mana availability, restricted items, etc.  
- **Cross-Realm State:** certain objects keep their **state** across realms (e.g., door that remembers “unlocked”), others **transform** (e.g., water ↔ crystal).  
- **Inventory & Tokens:** small inventory with realm tags (e.g., “future-tech”, “fantasy-arcane”).  
- **Knowledge Items:** notes & sigils that teach interactions (blueprints, runes).  
- **Light Puzzle scripting:** levers/terminals/inscriptions with shared IDs across realms.

## Systems (Rules)
- **Economy Swap:** credits ↔ gold ↔ barter; exchange is imperfect (rate loss).  
- **Time Flow:** tasks that take *n* minutes in one realm may take *n/2* or *2n* in another (gates, cooldowns).  
- **Access Control:** doors/bridges/wards exist in some realms, not in others.  
- **Hazards:** drones (future), wards/golems (fantasy), contamination zones (post-apoc).

## Camera & Controls
- 2D top-down (or high-tilt).  
- WASD movement; E interact; Q journal; I inventory; M map.

## Narrative Spine (MVP)
- **Act 1 – First Shift:** Learn the cycle; open the Town Hall archive by prepping in Day, entering at Night-Future.  
- **Act 2 – Cross-Realm Puzzle:** Brew an alchemical solvent in Fantasy to dissolve a Future alloy lock after the next shift.  
- **Act 3 – Reveal:** Discover a hidden “Convergence Engine” beneath the plaza and a hint of the true operator.

## Level Plan (MVP)
One **micro-city** (2–3 districts): Plaza Hub, Market Row, Old Library, Riverside.  
Paths differ per realm; 3 signature set-pieces demonstrate economy/time/physics changes.


## Production Scope (MVP Backlog)
- **Gameplay:** interaction system; realm shift controller; rule board UI; inventory & tags; 3 anchor puzzles; save/load.  
- **Content:** 1 hub + 2 districts; 6–8 NPCs with short arcs; 8–12 props with cross-realm behaviors.  
- **UI:** map, journal/quest log, inventory, settings.  
- **Audio/Art:** base tileset, 3 realm palettes, SFX for shift & interactions.

## Puzzle Examples (MVP)
- **Alloy Lock vs. Alchemical Solvent: **
- Setup: The Town Hall archive door (FUTURE) is sealed by a corrosion-proof alloy.
- Goal: Open the archive.
- Realm Rules Used: Crafting exists only in FANTASY; items keep state across realms; time flows slower in FANTASY.
- In FANTASY, collect herb → craft Solvent Vial.
- Place the vial on the alloy seam before the shift
- After the nightly shift to FUTURE, the alloy has been weakened and the player can continue.
- **Vine Bridge Time-Skip – Teaches: different time rates:**
- Setup: A broken footbridge blocks the Riverside path in Future.
Goal: Cross the gap.
Solution: Plant a Growth Seed in Fantasy (slow time won’t mature it). Wait/shift to Future (fast time) so the vine fully grows, creating a climbable route.


# Market Survey (Comparables & Differentiation)

| Title | Why comparable | Key takeaways | Our differentiators |
|---|---|---|---|
| **The Medium** | Dual-reality puzzle presentation | Clear communication of world differences | Multiple distinct realms; systemic (rules & economy), not only visual |
| **Titanfall 2 – Effect & Cause** | Time-shift level design | Instant contrast enables clever traversal | Persistent city hub; slower, planning-oriented cycle |
| **Zelda: A Link to the Past** | Light/Dark world mapping | Reusing space with different rules | Urban, narrative mystery; economy/time/physics triad |
| **Bioshock Infinite (tears)** | Alternate-reality interactions | Selective object/state crossover | Rule Board clarity; puzzle-first approach |
| **Legacy of Kain: Soul Reaver** | Plane-shifting puzzles | Geometry/state change readability | Multi-economy, systemic crafting & knowledge tokens |

**Positioning:** “A compact, story-rich 2D puzzler where **one city** is re-used across **multiple realities**, each with distinct rules that you exploit to progress.”

