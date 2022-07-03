export class Dice {
    // booo. privates not implemented yet
    //#nr = 6;
    //#id;
    __nr = 6;
    __id;

    constructor(diceid) {
        this.__id = diceid;
    }
    set value(nr) {
        this.__nr = nr;
        this.__showEyes();
    }
    get value() {
        return this.__nr;
    }

    __showEyes() {
        let eyes = [];
        for (let i = 1; i <= 7; i++)
        {
            eyes.push(document.querySelector(`#${this.__id}>.e${i}`));
            eyes[i-1].style.visibility = "hidden";
        }

        switch (this.__nr) {
            case 1: {
                eyes[6].style.visibility = "visible";
                break;
            }
            case 2: {
                eyes[0].style.visibility = "visible";
                eyes[5].style.visibility = "visible";
                break;
            }
            case 3: {
                eyes[1].style.visibility = "visible";
                eyes[4].style.visibility = "visible";
                eyes[6].style.visibility = "visible";
                break;
            }
            case 4: {
                eyes[0].style.visibility = "visible";
                eyes[1].style.visibility = "visible";
                eyes[4].style.visibility = "visible";
                eyes[5].style.visibility = "visible";
                break;
            }
            case 5: {
                eyes[0].style.visibility = "visible";
                eyes[1].style.visibility = "visible";
                eyes[4].style.visibility = "visible";
                eyes[5].style.visibility = "visible";
                eyes[6].style.visibility = "visible";
                break;
            }
            case 6: {
                eyes[0].style.visibility = "visible";
                eyes[1].style.visibility = "visible";
                eyes[2].style.visibility = "visible";
                eyes[3].style.visibility = "visible";
                eyes[4].style.visibility = "visible";
                eyes[5].style.visibility = "visible";
                break;
            }
            default:
            {
                console.error("Invalid dicve number");
                break;
            }
        }
    }
}