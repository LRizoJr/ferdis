export interface IItem {
    id: number;
    itemType: IItemType;
    name: string;
    price: number;
    imageUrl: string;
}

// Item Type Definition (e.g.: IceCream, Pudding)
export interface IItemType {
    id: number;
    name: string;
}