function solve() {

    function cast(spellName) {
        this.mana--;
        console.log(`${this.name} cast ${spellName}`);
    }

    function fight() {
        this.stamina--;
        console.log(`${this.name} slashes at the foe!`);
    }

    function mage(name) {
        return Object.assign(
            {
                name,
                health: 100,
                mana: 100
            },
            { cast }
        )
    }

    function fighter(name) {
        return Object.assign(
            {
                name,
                health: 100,
                stamina: 100
            },
            { fight }
        )
    }

    return {
        mage,
        fighter,
    }
}

let create = solve();
const scorcher = create.mage("Scorcher");
scorcher.cast("fireball")
scorcher.cast("thunder")
scorcher.cast("light")

const scorcher2 = create.fighter("Scorcher 2");
scorcher2.fight()

console.log(scorcher2.stamina);
console.log(scorcher.mana);