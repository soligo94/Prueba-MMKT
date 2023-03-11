export class CategoryProductGroupService {

    getFamilies() {
        return fetch('./categories.json').then(res => res.json())
        .then(d => d.data);
    }
}