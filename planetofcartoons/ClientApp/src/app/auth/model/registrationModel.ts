export class RegistrationModel {
    public Email: string;
    public Password: string;
    public ConfirmPassword: string;

    constructor(email: string, pwd: string, confPwd: string) {
        this.Email = email;
        this.Password = pwd;
        this.ConfirmPassword = confPwd;
    }
}
