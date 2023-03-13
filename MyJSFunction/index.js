export const handler = async (event) => {
    return {
      statusCode: 200,
      body: JSON.stringify({ message: "This is my JavaScript API (JavaScript is better than C# change my mind)" }),
    };
  };