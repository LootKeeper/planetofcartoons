export enum RoleType {
    User = 'User',
    Admin = 'Admin'
}

export function convertToRoles(roles: string): RoleType[] {
    let convertedRoles: RoleType[] = [];
    if (Array.isArray(roles)) {
        for (var i in roles) {
            convertedRoles.push(convertToRole(roles[i]));
        }
    } else {
        convertedRoles.push(convertToRole(roles));
    }

    return convertedRoles;
}

function convertToRole(roleTypeInString: string): RoleType {
    let roleType: RoleType = <RoleType>RoleType[roleTypeInString];
    return roleType;
}
