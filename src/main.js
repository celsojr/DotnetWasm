// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

import { dotnet } from './_framework/dotnet.js'

const { setModuleImports, getAssemblyExports, getConfig } = await dotnet.create()

setModuleImports("main.js", {
    window: {
        location: {
            // Properties need special attention when importing
            href: () => globalThis.window.location.href
        }
    }
})

const config = getConfig()
const exports = await getAssemblyExports(config.mainAssemblyName)
const text = exports.Program.Greeting()
console.log(text)

document.querySelector('span').innerText = text
await dotnet.run()
