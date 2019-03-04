"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var RoleType;
(function (RoleType) {
    RoleType["User"] = "User";
    RoleType["Admin"] = "Admin";
})(RoleType = exports.RoleType || (exports.RoleType = {}));
function convertToRoles(roles) {
    var convertedRoles = [];
    if (Array.isArray(roles)) {
        for (var i in roles) {
            convertedRoles.push(convertToRole(roles[i]));
        }
    }
    else {
        convertedRoles.push(convertToRole(roles));
    }
    return convertedRoles;
}
exports.convertToRoles = convertToRoles;
function convertToRole(roleTypeInString) {
    var roleType = RoleType[roleTypeInString];
    return roleType;
}
//# sourceMappingURL=roleType.js.map