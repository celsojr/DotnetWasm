// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

import { dotnet } from './dotnet.js'
import Modules from './modules.js'

const { getAssemblyExports, getConfig } = await dotnet.create();

const modules = new Modules();
await modules.import();

const config = getConfig();
const exports = await getAssemblyExports(config.mainAssemblyName);
const text = exports.Program.Greeting();
console.log(text);

document.getElementById('out').innerHTML = text;
await dotnet.run();
