"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.OutputChannel = void 0;
const vscode = require("vscode");
const global_1 = require("./global");
class OutputChannel {
    static show() {
        OutputChannel.outputChannel.show(true);
    }
    static appendLine(value, show) {
        if (show)
            OutputChannel.outputChannel.show(true);
        OutputChannel.outputChannel.appendLine(value);
    }
    static displayResults(uri, title, res, showInCurrentPanel = false) {
        let viewColumn = OutputChannel.getViewColumn();
        if (showInCurrentPanel)
            viewColumn -= 1;
        global_1.Global.ResultManager.showResults(uri, viewColumn, res);
    }
    static getViewColumn() {
        const resourceColumn = (vscode.window.activeTextEditor && vscode.window.activeTextEditor.viewColumn) || vscode.ViewColumn.One;
        return resourceColumn + 1;
    }
}
exports.OutputChannel = OutputChannel;
OutputChannel.outputChannel = vscode.window.createOutputChannel('PostgreSQL');
//# sourceMappingURL=outputChannel.js.map