module home {

    export interface ISampleInput {
        text: string,
        isVisible: boolean,
        convertedText: string,
    }

    export class SampleInput {
        private _text: string;

        public get text() {
            return this._text;
        }
        public set text(text: string) {
            if (this._text != text) {
                this._text = text;

                if (this._text == null) {
                    this.convertedText = null;
                }
                else {
                    this.convertedText = this._text.toUpperCase();
                }
            }
        }

        isVisible: boolean;
        convertedText: string;

        static Current = new SampleInput();

        constructor(obj?: ISampleInput) {
            if (typeof obj == "SampleInput") {
                return obj as SampleInput;
            }
            _.extend(this, obj || {
                text: null,
                convertedText: null,
                isVisible: true
            });
        }

        toggleVisible() {
            this.isVisible = !this.isVisible;
        }
    }

}