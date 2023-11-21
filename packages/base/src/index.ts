﻿/** 
 * ## Serenity Base Library
 * 
 * This is the package containing base types and functions used in Serenity applications.
 * 
 * The main entry for the NPM package is `@serenity-is/base`. This should be installed by default 
 * in your projects created from `Serene` or `StartSharp` template indirectly via 
 * `@serenity-is/corelib` package which references `@serenity-is/base`.
 * 
 * ```json
 * {
 *   "dependencies": {
 *     // ...
 *     "@serenity-is/corelib": "6.9.0"
 *   }
 * }
 * ```
 * 
 * The version number for this package should be equal or as close as possible to Serenity NuGet package versions in your project file.
 * @packageDocumentation
 */

export * from "./criteria";
export * from "./debounce";
export * from "./formatting";
export * from "./html";
export * from "./lookup";
export * from "./propertyitem";
export * from "./servicetypes";
export * from "./system";