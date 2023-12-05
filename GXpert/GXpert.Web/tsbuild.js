import { build, importAsGlobalsMapping } from "@serenity-is/tsbuild";

await build({
    importAsGlobals: Object.assign({
        "jquery": "jQuery"
    }, importAsGlobalsMapping)
});
