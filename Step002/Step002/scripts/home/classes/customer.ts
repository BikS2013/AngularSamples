module home {
    export interface ICustomer {
        id?: string; 
        name?: string; 
        address?: string; 
    }

    var $http = angular.injector(['ng']).get<ng.IHttpService>('$http');

    export class Customer implements ICustomer {
        id: string; 
        name: string; 
        address: string; 

        costructor(obj?: ICustomer, clone: boolean = false) {
            if (typeof obj == "Customer" && !clone) {
                return obj as Customer; 
            }
            _.extend(this, obj || { id: uuid.v4() });
        }


        insert = () => {
            var result = $http.post("api/customer/add", this);
            result.then((data) => {

            }, () => { });

        }
    }

}