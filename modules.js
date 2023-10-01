import { dotnet } from './dotnet.js'

class modules {
    imports = null

    constructor() {
        this.initializeImports()
    }

    async initializeImports() {
        const { setModuleImports } = await dotnet.create()
        this.imports = setModuleImports;
    }

    async import() {
        if (!this.imports) {
            await this.initializeImports()
        }

        this.imports('main.js', {
            window: {
                location: {
                    href: () => globalThis.window.location.href
                },
                alert: (message) => globalThis.window.alert(message)
            },
            console: {
                warn: (message) => globalThis.window.console.warn(message),
                error: (message) => globalThis.window.console.error(message)
            }
        })
    }
}

export default modules
